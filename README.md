
# Tenjin Implementation in Android for AppLovin
<br/>

- Download and import the Tenjin Unity Package from [here](https://github.com/tenjin/tenjin-unity-sdk/releases). <br/> 
- Add the following lines in the Android Manifest: <br/>

  ```
  <uses-permission android:name="android.permission.INTERNET" /> 
  <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
  <uses-permission android:name="com.google.android.gms.permission.AD_ID"/>
  ```
<p align="center">
<img src="https://i.ibb.co/MRLXQvb/Screenshot-2024-02-15-at-2-38-25-PM.png" alt="Screenshot-2024-02-15-at-2-38-25-PM" border="0">
</p>

- Now, add the following dependencies in your mainTemplate.gradle file

  ```
  dependencies {
    implementation 'com.google.android.gms:play-services-ads-identifier:{version}'
    implementation 'com.android.installreferrer:installreferrer:{version}'
  }
  ```
  <p align="center">
<img src="https://i.ibb.co/MRY7Bf7/Screenshot-2024-02-15-at-2-52-22-PM.png" alt="Screenshot-2024-02-15-at-2-52-22-PM" border="0">
</p> 

- Download the TenjinInit.cs file from this repo and add it to your AdsInitializer plugin <br/>

- In the TenjinInit file, go to the **TenjinConnect** function, and add your key as a string where *instance* is being created <br/>

   <p align="center">
<img src="https://i.ibb.co/7b0nkC6/Screenshot-2024-02-15-at-4-10-48-PM.png" alt="Screenshot-2024-02-15-at-4-10-48-PM" border="0">
</p> 


- Add *tenjin_applovin_enabled* as a scripting symbol


## For Testing
- Make sure your logcat shows the following logs or something similar:


  <p align="center">
    <img src="https://i.ibb.co/ZN9Qqw3/Screenshot-2024-02-12-at-5-29-47-PM.png" alt="Screenshot-2024-02-12-at-5-29-47-PM" border="0">
</p> 

<p align="center">
<img src="https://i.ibb.co/j5h87YF/Screenshot-2024-02-12-at-5-30-24-PM.png" alt="Screenshot-2024-02-12-at-5-30-24-PM" border="0">
</p> 



## Additional Info

- Unity might get stuck in an infinite loop when importing the Tenjin Unity Package. Untick **Editor** folder to solve the issue

 <p align="center">
<img src="https://i.ibb.co/KFKJ5w9/Screenshot-2024-02-15-at-3-04-13-PM.png" alt="Screenshot-2024-02-15-at-3-04-13-PM" border="0">
</p> 


