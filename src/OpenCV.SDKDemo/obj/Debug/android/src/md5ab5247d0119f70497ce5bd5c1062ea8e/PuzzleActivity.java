package md5ab5247d0119f70497ce5bd5c1062ea8e;


public class PuzzleActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		org.opencv.android.CameraBridgeViewBase.CvCameraViewListener,
		org.opencv.android.LoaderCallbackInterface,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onCreateOptionsMenu:(Landroid/view/Menu;)Z:GetOnCreateOptionsMenu_Landroid_view_Menu_Handler\n" +
			"n_onOptionsItemSelected:(Landroid/view/MenuItem;)Z:GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler\n" +
			"n_onCameraFrame:(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;:GetOnCameraFrame_Lorg_opencv_core_Mat_Handler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV\n" +
			"n_onCameraViewStarted:(II)V:GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV\n" +
			"n_onCameraViewStopped:()V:GetOnCameraViewStoppedHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV\n" +
			"n_onManagerConnected:(I)V:GetOnManagerConnected_IHandler:OpenCV.Android.ILoaderCallbackInterfaceInvoker, OpenCV\n" +
			"n_onPackageInstall:(ILorg/opencv/android/InstallCallbackInterface;)V:GetOnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_Handler:OpenCV.Android.ILoaderCallbackInterfaceInvoker, OpenCV\n" +
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("OpenCV.SDKDemo.Puzzle.PuzzleActivity, OpenCV.SDKDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PuzzleActivity.class, __md_methods);
	}


	public PuzzleActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PuzzleActivity.class)
			mono.android.TypeManager.Activate ("OpenCV.SDKDemo.Puzzle.PuzzleActivity, OpenCV.SDKDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public boolean onCreateOptionsMenu (android.view.Menu p0)
	{
		return n_onCreateOptionsMenu (p0);
	}

	private native boolean n_onCreateOptionsMenu (android.view.Menu p0);


	public boolean onOptionsItemSelected (android.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (android.view.MenuItem p0);


	public org.opencv.core.Mat onCameraFrame (org.opencv.core.Mat p0)
	{
		return n_onCameraFrame (p0);
	}

	private native org.opencv.core.Mat n_onCameraFrame (org.opencv.core.Mat p0);


	public void onCameraViewStarted (int p0, int p1)
	{
		n_onCameraViewStarted (p0, p1);
	}

	private native void n_onCameraViewStarted (int p0, int p1);


	public void onCameraViewStopped ()
	{
		n_onCameraViewStopped ();
	}

	private native void n_onCameraViewStopped ();


	public void onManagerConnected (int p0)
	{
		n_onManagerConnected (p0);
	}

	private native void n_onManagerConnected (int p0);


	public void onPackageInstall (int p0, org.opencv.android.InstallCallbackInterface p1)
	{
		n_onPackageInstall (p0, p1);
	}

	private native void n_onPackageInstall (int p0, org.opencv.android.InstallCallbackInterface p1);


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
