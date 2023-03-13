# VTween
 A compact tweening library for Unity3D. Inspired by the legendary LeanTween.  
 
## **Features**
- Object Pooling.  
- Low allocation.  
- Blazingly fast.

## **Requirement**
- Unity3D 2022.2.x and above.  
 
## **Installation**</br>
- Download the .zip and unpack it to your Assets folder in your project.  
- Add the reference `using Breadnone;`

## **UIToolkit ~Experimental**
UIToolkit should work as long as you're using Unity editor 2022.2.x and above due to style translate api.  

## **Optimization**
- By default the pooled object is set to 10 instances. For heavy usages we can set this to as much as we want BUT you should be careful, changing it to a bigger pool when not used will allocate tons of memory, so use it wisely.  
```C#
  // Changes the max number of object pooling and. Returns boolean
  // Note: If pools are in use, it will return false. Make sure all tweens already finished before resizing the pool. 
  
  VTween.FlushPools(15);
```


## Syntax
```C#
  // Move
  VTween.move(obj, target, duration).setOnComplete(()=>
  {
     UnityEngine.Debug.Log("Was completed!");
                    
  }).setEase(Ease.Linear).setLoop(3).setPingPong(true).setOnCompleteRepeat(true);

  // Rotate
  VTween.rotate(ThreeDObject, rotationInVec3, Vector3.forward, duration).setEase(Ease.Linear).setLoop(2).setPingPong(true);
                
  // Scale
  VTween.scale(obj, new Vector3(2, 2, 2), duration).setEase(Ease.Linear).setLoop(3);

  //Chaining
  var queue = VTween.queue.add(VTween.move(gameObject, new Vector3(100, 200, 2), duration).setEase(Ease.Linear))
    .add(VTween.move(gameObject, new Vector3(200, 300, 200), duration))
    .add(VTween.move(gameObject, defaultPos, duration));

  // ExecuteLater (Similar to LeanTween.delayedCall)
  VTween.execLater(5, ()=> {UnityEngine.Debug.Log("Done waiting!");});
                
  // Frame-by-frame animation(VTween.animation)
  Image[] arr = new Image[11];
  VTween.animation(arr, duration, 60).setDisableOnComplete(true).setLoop(loopCount).setPingPong(true);
                
  // Alpha
  VTween.alpha(canvasGroup, 0f, 1f, 5f); //for legacy UI
  // OR
  VTween.alpha(visualElement, 0f, 1f, 5f); //for UIToolkit
                
  // Color
  var legacyImage = gameObject.GetComponent<Image>();
  VTween.color(legacyImage, new Color(0.2f, 0.1f, 0.2f, 1), 5);
                
  // Follow
  var target = someTarget.GetComponent<Transform>();
  VTween.follow(gameObject, target, new Vector3(0f, 0f, 0.1f), 5f);
                
  // ShaderProperty // Lerps or interpolates values (apis : shaderFloat, shaderVector2, shaderVector3)
  var myMaterials = gameObject.GetComponent<Renderer>().materials;
  VTween.shaderFloat(myMaterials[0], "_myFloatRef", 0, 2, 5); 
                
  // Value // Interpolates float value(supported types: float, Vector2, Vector3, Vector4)
  VTween.value(0f, 5f, 3f, (x)=> {Debug.Log("running value : " + x)});

  //Cancel
  VTween.Cancel(gameObject);      //GameObjects
  VTween.Cancel(visualElement);   //UIToolkit
  VTween.CancelAll();             //Cancels all active/paused tweens
                
```
 
#### **Struct based tweening class**  
 A fire & forget struct based tween instance. Use this only when you don't need to cancel/pause the tween (thus FireAndForget).  
#### Note:
 - The gameObject/VisualElement tied to this instance can't be destroyed while being active!  
 - MUST use VTween.TryForceCancel(gameObject) to cancel! Not recommended for mass cancelling!  
 - Can't be cached in a collections/arrays/fields (Fire-and-Forget remember :)).  
 
 ```C#
   //Fast & low allocation api. Allocated on the stack
   var t = VTween.moveFast(obj, target.position, duration, ease:Ease.Linear);
   
   //The instance can't be cached on collections/arrays/fields.
   //This is slow cancelling and as stated this api is for Fire-and-Forget. 
   VTween.TryForceCancel(obj);
 ```
 
 #### **To Do:**
 - CustomYieldInstruction. Currently uses it's own timing.  
 - Port more LeanTween apis.
 - Only 70% UIToolkit implementation completed. 

https://user-images.githubusercontent.com/64100867/220118744-85f4dee1-a35b-4772-ae41-83688e9b810a.mp4

