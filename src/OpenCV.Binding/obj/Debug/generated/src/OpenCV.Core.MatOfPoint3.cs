using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']"
	[global::Android.Runtime.Register ("org/opencv/core/MatOfPoint3", DoNotGenerateAcw=true)]
	public partial class MatOfPoint3 : global::OpenCV.Core.Mat {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/MatOfPoint3", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatOfPoint3); }
		}

		protected MatOfPoint3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLorg_opencv_core_Point3_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/constructor[@name='MatOfPoint3' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point3...']]"
		[Register (".ctor", "([Lorg/opencv/core/Point3;)V", "")]
		public unsafe MatOfPoint3 (params global:: OpenCV.Core.Point3[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MatOfPoint3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lorg/opencv/core/Point3;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lorg/opencv/core/Point3;)V", __args);
					return;
				}

				if (id_ctor_arrayLorg_opencv_core_Point3_ == IntPtr.Zero)
					id_ctor_arrayLorg_opencv_core_Point3_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorg/opencv/core/Point3;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorg_opencv_core_Point3_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLorg_opencv_core_Point3_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/constructor[@name='MatOfPoint3' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register (".ctor", "(Lorg/opencv/core/Mat;)V", "")]
		public unsafe MatOfPoint3 (global::OpenCV.Core.Mat p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MatOfPoint3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/opencv/core/Mat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Mat;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Mat_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Mat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Mat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/constructor[@name='MatOfPoint3' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MatOfPoint3 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MatOfPoint3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/constructor[@name='MatOfPoint3' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe MatOfPoint3 (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MatOfPoint3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_alloc_I;
#pragma warning disable 0169
		static Delegate GetAlloc_IHandler ()
		{
			if (cb_alloc_I == null)
				cb_alloc_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Alloc_I);
			return cb_alloc_I;
		}

		static void n_Alloc_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.MatOfPoint3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alloc (p0);
		}
#pragma warning restore 0169

		static IntPtr id_alloc_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/method[@name='alloc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alloc", "(I)V", "GetAlloc_IHandler")]
		public virtual unsafe void Alloc (int p0)
		{
			if (id_alloc_I == IntPtr.Zero)
				id_alloc_I = JNIEnv.GetMethodID (class_ref, "alloc", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alloc_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alloc", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fromArray_arrayLorg_opencv_core_Point3_;
#pragma warning disable 0169
		static Delegate GetFromArray_arrayLorg_opencv_core_Point3_Handler ()
		{
			if (cb_fromArray_arrayLorg_opencv_core_Point3_ == null)
				cb_fromArray_arrayLorg_opencv_core_Point3_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FromArray_arrayLorg_opencv_core_Point3_);
			return cb_fromArray_arrayLorg_opencv_core_Point3_;
		}

		static void n_FromArray_arrayLorg_opencv_core_Point3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.MatOfPoint3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point3[] p0 = (global::OpenCV.Core.Point3[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::OpenCV.Core.Point3));
			__this.FromArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_fromArray_arrayLorg_opencv_core_Point3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/method[@name='fromArray' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point3...']]"
		[Register ("fromArray", "([Lorg/opencv/core/Point3;)V", "GetFromArray_arrayLorg_opencv_core_Point3_Handler")]
		public virtual unsafe void FromArray (params global:: OpenCV.Core.Point3[] p0)
		{
			if (id_fromArray_arrayLorg_opencv_core_Point3_ == IntPtr.Zero)
				id_fromArray_arrayLorg_opencv_core_Point3_ = JNIEnv.GetMethodID (class_ref, "fromArray", "([Lorg/opencv/core/Point3;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fromArray_arrayLorg_opencv_core_Point3_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromArray", "([Lorg/opencv/core/Point3;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_fromList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetFromList_Ljava_util_List_Handler ()
		{
			if (cb_fromList_Ljava_util_List_ == null)
				cb_fromList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FromList_Ljava_util_List_);
			return cb_fromList_Ljava_util_List_;
		}

		static void n_FromList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.MatOfPoint3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FromList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fromList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/method[@name='fromList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("fromList", "(Ljava/util/List;)V", "GetFromList_Ljava_util_List_Handler")]
		public virtual unsafe void FromList (global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p0)
		{
			if (id_fromList_Ljava_util_List_ == IntPtr.Zero)
				id_fromList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "fromList", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fromList_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromList", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromNativeAddr_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/method[@name='fromNativeAddr' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("fromNativeAddr", "(J)Lorg/opencv/core/MatOfPoint3;", "")]
		public static unsafe global::OpenCV.Core.MatOfPoint3 FromNativeAddr (long p0)
		{
			if (id_fromNativeAddr_J == IntPtr.Zero)
				id_fromNativeAddr_J = JNIEnv.GetStaticMethodID (class_ref, "fromNativeAddr", "(J)Lorg/opencv/core/MatOfPoint3;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint3> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromNativeAddr_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.MatOfPoint3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Lorg/opencv/core/Point3;", "GetToArrayHandler")]
		public virtual unsafe global::OpenCV.Core.Point3[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Lorg/opencv/core/Point3;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::OpenCV.Core.Point3[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (global::OpenCV.Core.Point3));
				else
					return (global::OpenCV.Core.Point3[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toArray", "()[Lorg/opencv/core/Point3;")), JniHandleOwnership.TransferLocalRef, typeof (global::OpenCV.Core.Point3));
			} finally {
			}
		}

		static Delegate cb_toList;
#pragma warning disable 0169
		static Delegate GetToListHandler ()
		{
			if (cb_toList == null)
				cb_toList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToList);
			return cb_toList;
		}

		static IntPtr n_ToList (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.MatOfPoint3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (__this.ToList ());
		}
#pragma warning restore 0169

		static IntPtr id_toList;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='MatOfPoint3']/method[@name='toList' and count(parameter)=0]"
		[Register ("toList", "()Ljava/util/List;", "GetToListHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> ToList ()
		{
			if (id_toList == IntPtr.Zero)
				id_toList = JNIEnv.GetMethodID (class_ref, "toList", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}