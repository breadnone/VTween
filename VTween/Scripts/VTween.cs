/*
MIT License

Copyright 2023 Stevphanie Ricardo

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the "Software"), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using UnityEngine;
using VTWeen.Extension;
using UnityEngine.UIElements;
using System;

namespace VTWeen
{
    public static class VTween
    { 
        #region Move
        ///<summary>Moves object to target position Vector3.</summary>
        public static VTweenMove move(GameObject gameObject, Vector3 to, float duration)
        {
            //return new VTweenMove(gameObject.transform, null, to, duration);// Non pooling solution
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, to, trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object to target position.</summary>
        public static VTweenMove move(Transform transform, Vector3 to, float duration)
        {
            //return new VTweenMove(gameObject.transform, null, to, duration);// Non pooling solution
            var instance = new VTweenMove();
            var trans = transform;
            instance.SetBaseValues(trans, null, to, trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object to target position.</summary>
        public static VTweenMove move(Transform transform, Transform to, float duration)
        {
            //return new VTweenMove(gameObject.transform, null, to, duration);// Non pooling solution
            var instance = new VTweenMove();
            var trans = transform;
            instance.SetBaseValues(trans, null, to.position, trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on target's transform.</summary>
        public static VTweenMove move(GameObject gameObject, Transform to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, to.position, trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on target's ITransform on VisualElement.</summary>
        public static VTweenMove move(VisualElement visualElement, Vector3 to, float duration)
        {
            var instance = new VTweenMove();
            instance.SetBaseValues(null, visualElement.transform, to, visualElement.transform.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object localSpace.</summary>
        public static VTweenMove moveLocal(GameObject gameObject, Vector3 to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, to, trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on target's localTransform.</summary>
        public static VTweenMove moveLocal(GameObject gameObject, Transform to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, to.localPosition, trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on target's localTransform.</summary>
        public static VTweenMove moveLocal(Transform transform, Transform to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, to.localPosition, trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's X axis.</summary>
        public static VTweenMove moveX(GameObject gameObject, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, new Vector3(to, trans.position.y, trans.position.z), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's X axis.</summary>
        public static VTweenMove moveX(Transform transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.SetBaseValues(trans, null, new Vector3(to, trans.position.y, trans.position.z), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's X axis.</summary>
        public static VTweenMove moveX(VisualElement visualElement, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = visualElement.transform;
            instance.SetBaseValues(null, visualElement.transform, new Vector3(to, trans.position.y, trans.position.z), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's X axis localSpace.</summary>
        public static VTweenMove moveLocalX(GameObject gameObject, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, new Vector3(to, trans.localPosition.y, trans.localPosition.z), trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's X axis localSpace.</summary>
        public static VTweenMove moveLocalX(Transform transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, new Vector3(to, trans.localPosition.y, trans.localPosition.z), trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Y axis.</summary>
        public static VTweenMove moveY(GameObject gameObject, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, new Vector3(trans.position.x, to, trans.position.z), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Y axis.</summary>
        public static VTweenMove moveY(Transform transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.SetBaseValues(trans, null, new Vector3(trans.position.x, to, trans.position.z), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Y axis of a VisualElement.</summary>
        public static VTweenMove moveY(VisualElement visualElement, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = visualElement.transform;
            instance.SetBaseValues(null, visualElement.transform, new Vector3(trans.position.x, to, trans.position.z), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Y axis localSpace.</summary>
        public static VTweenMove moveLocalY(GameObject gameObject, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, new Vector3(trans.localPosition.x, to, trans.localPosition.z), trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Y axis localSpace.</summary>
        public static VTweenMove moveLocalY(Transform transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, new Vector3(trans.localPosition.x, to, trans.localPosition.z), trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Z axis.</summary>
        public static VTweenMove moveZ(GameObject gameObject, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, new Vector3(trans.position.x, trans.position.y, to), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Z axis.</summary>
        public static VTweenMove moveZ(Transform transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.SetBaseValues(trans, null, new Vector3(trans.position.x, trans.position.y, to), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's Z axis of a VisualElement.</summary>
        public static VTweenMove moveZ(VisualElement transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform.transform;
            instance.SetBaseValues(null, trans, new Vector3(trans.position.x, trans.position.y, to), trans.position, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's local Z axis.</summary>
        public static VTweenMove moveLocalZ(GameObject gameObject, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = gameObject.transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, new Vector3(trans.localPosition.x, trans.localPosition.y, to), trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Moves object based on object's local Z axis.</summary>
        public static VTweenMove moveLocalZ(Transform transform, float to, float duration)
        {
            var instance = new VTweenMove();
            var trans = transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, new Vector3(trans.localPosition.x, trans.localPosition.y, to), trans.localPosition, duration);
            instance.AssignMainEvent();
            return instance;
        }
        #endregion

        #region Rotate
        ///<summary>Rotates object based on angle value.</summary>
        public static VTweenRotate rotate(GameObject gameObject, float angle, Vector3 direction, float duration)
        {
            var instance = new VTweenRotate();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, angle, direction, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Rotates VisualElement based on angle value.</summary>
        public static VTweenRotate rotate(VisualElement visualObject, float angle, Vector3 direction, float duration)
        {
            var instance = new VTweenRotate();
            var trans = visualObject.transform;
            instance.SetBaseValues(null, trans, angle, direction, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Rotates object based on angle value.</summary>
        public static VTweenRotate rotateLocal(GameObject gameObject, float to, Vector3 direction, float duration)
        {
            var instance = new VTweenRotate();
            var trans = gameObject.transform;
            instance.ivcommon.isLocal = true;
            instance.SetBaseValues(trans, null, to, direction, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on Vector3.</summary>
        public static VTweenScale scale(GameObject gameObject, Vector3 targetScale, float duration)
        {
            var instance = new VTweenScale();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, targetScale, trans.localScale, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on Vector3.</summary>
        public static VTweenScale scale(GameObject gameObject, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, trans.localScale, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on X axis.</summary>
        public static VTweenScale scaleX(GameObject gameObject, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, new Vector3(targetTransform.localScale.x, trans.localScale.y, trans.localScale.z), duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on Y axis.</summary>
        public static VTweenScale scaleY(GameObject gameObject, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, new Vector3(trans.localScale.x, targetTransform.localScale.y, trans.localScale.z), duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on Z axis.</summary>
        public static VTweenScale scaleZ(GameObject gameObject, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = gameObject.transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, new Vector3(trans.localScale.x, trans.localScale.y, targetTransform.localScale.z), duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on Vector3.</summary>
        public static VTweenScale scale(Transform transform, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, trans.localScale, duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on X axis.</summary>
        public static VTweenScale scaleX(Transform transform, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, new Vector3(trans.localScale.x, targetTransform.localScale.y, targetTransform.localScale.z), duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on X axis.</summary>
        public static VTweenScale scaleY(Transform transform, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, new Vector3(targetTransform.localScale.x, trans.localScale.y, targetTransform.localScale.z), duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on X axis.</summary>
        public static VTweenScale scaleZ(Transform transform, Transform targetTransform, float duration)
        {
            var instance = new VTweenScale();
            var trans = transform;
            instance.SetBaseValues(trans, null, targetTransform.localScale, new Vector3(trans.localScale.x, trans.localScale.y, targetTransform.localScale.z), duration);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Scales object based on Vector3.</summary>
        public static VTweenScale scale(Transform transform, Vector3 targetScale, float duration)
        {
            var instance = new VTweenScale();
            var trans = transform;
            instance.SetBaseValues(trans, null, targetScale, trans.localScale, duration);
            instance.AssignMainEvent();
            return instance;
        }
        #endregion

        #region Value
        ///<summary>Interpolates float value.</summary>
        public static VTweenValueFloat value(float from, float to, float time)
        {
            var instance = new VTweenValueFloat();
            instance.SetBaseValues(from, to, time, null);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Interpolates float value with custom callback.</summary>
        public static VTweenValueFloat value(float from, float to, float time, Action<float>callback)
        {
            var instance = new VTweenValueFloat();
            instance.SetBaseValues(from, to, time, callback);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Interpolates Vector3 value with custom callback.</summary>
        public static VTweenValueVector3 value(Vector3 from, Vector3 to, float time, Action<Vector3>callback)
        {
            var instance = new VTweenValueVector3();
            instance.SetBaseValues(from, to, time, callback);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Interpolates Vector3 value.</summary>
        public static VTweenValueVector3 value(Vector3 from, Vector3 to, float time)
        {
            var instance = new VTweenValueVector3();
            instance.SetBaseValues(from, to, time, null);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Waits certain amounnt of time before executing.</summary>
        public static VTweenExecLater execLater(float time, Action callback)
        {
            var instance = new VTweenExecLater();
            instance.SetBaseValues(time, callback);
            instance.Init();
            return instance;
        }
        #endregion

        #region Alpha
        ///<summary>Interpolates the alpha/opacity value of a CanvasGroup or VisualElement.</summary>
        public static VTweenAlpha alpha(CanvasGroup canvasGroup, float from, float to, float time)
        {
            var instance = new VTweenAlpha();
            instance.SetBaseValues(canvasGroup, null, from, to, time);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Interpolates the alpha/opacity value of a CanvasGroup or VisualElement.</summary>
        public static VTweenAlpha alpha(VisualElement visualElement, float from, float to, float time)
        {
            var instance = new VTweenAlpha();
            instance.SetBaseValues(null, visualElement, from, to, time);
            instance.AssignMainEvent();
            return instance;
        }
        #endregion

        #region  Utility
        ///<summary>Frame-by-frame animation based on array legacy UI Image.</summary>
        public static VTweenAnimation animation(UnityEngine.UI.Image[] legacyImages, float time, int fps = 12)
        {
            var instance = new VTweenAnimation();
            instance.SetBaseValues(legacyImages, null, fps, time);
            instance.AssignMainEvent();
            return instance;
        }
        ///<summary>Frame-by-frame animation based on array of UIElements.Image.</summary>
        public static VTweenAnimation animation(UnityEngine.UIElements.Image[] uiimages, float time, int fps = 12)
        {
            var instance = new VTweenAnimation();
            instance.SetBaseValues(null, uiimages, fps, time);
            instance.AssignMainEvent();
            return instance;
        }
        public static int ActiveTweenCount
        {
            get
            {
                var t = VExtension.GetActiveTweens();

                if (t == null)
                    return 0;
                else
                    return t.Length;
            }
        }
        ///<summary>Returns int of total paused tween instances.</summary>
        public static int PausedTweenCount
        {
            get
            {
                var t = VExtension.GetPausedTweens();

                if (t == null)
                    return 0;
                else
                    return t.Length;
            }
        }
        ///<summary>Pauses single isntance of active tween.</summary>
        public static void Pause(VTweenClass vtween)
        {
            VExtension.Pause(vtween, false);
        }
        ///<summary>Resume single instance of tween.</summary>
        public static void Resume(VTweenClass vtween)
        {
            VExtension.Resume(vtween, false);
        }
        ///<summary>Resumes all tweens.</summary>
        public static void ResumeAll()
        {
            VExtension.Resume(null, true);
        }
        ///<summary>Pauses all tweens.</summary>
        public static void PauseAll()
        {
            VExtension.Pause(null, true);
        }
        ///<summary>Cancels all tweens.</summary>
        public static void CancelAll()
        {
            VExtension.Cancel(null, true);
        }
        ///<summary>Cancel single instance of active tween.</summary>
        public static void Cancel(VTweenClass vtween, bool executeOnComplete = false)
        {
            VExtension.Cancel(vtween, false);
        }

        ///<summary>Returns array of active tweens.</summary>
        private static VTweenClass[] GetActiveTween(VTweenClass t)
        {
            var val = VExtension.GetActiveTweens();
            
            if(val == null)
                return null;
            else
                return VExtension.GetActiveTweens();
        }
        ///<summary>Checks if an instance is tweening.</summary>
        public static bool IsTweening(VTweenClass vtween){return vtween.IsTweening();}
        ///<summary>Check if tween instance is tweening.</summary>
        public static bool IsTweening(int customId)
        {
            for(int i = 0; i < VTweenManager.activeTweens.Count; i++)
            {
                var val = VTweenManager.activeTweens[i];
                
                if(val != null && val.ivcommon.id == customId)
                    return true;
            }

            return false;
        }
        #endregion
    }
}