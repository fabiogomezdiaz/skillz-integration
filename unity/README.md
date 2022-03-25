# Implementations

## Create New Game from Specific Template

```bash
# Go to implementations folder
cd implementations

# Select your desired game by uncommenting one of the versions below
#GAME_NAME="Driver-2019.4.35f1"
#GAME_NAME="Driver-2020.3.27f1"
#GAME_NAME="Driver-2021.2.10f1"

# Select your desired SDK version by uncommenting one of the versions below
#SDK_VERSION="27.2.8"
#SDK_VERSION="28.0.5"
#SDK_VERSION="28.0.11"
cp -r "../_game-templates/${GAME_NAME}" "./${GAME_NAME}-SDK-${SDK_VERSION}"

# Go to your game directory
cd "./${GAME_NAME}-SDK-${SDK_VERSION}"

# Remove any environment specific files
rm -rf .vscode Library Temp

# Remove Builds
rm -rf Build
rm -rf Builds
```

## Accepting Android License Agreements

```bash
# Editor Version and Android SDK Root
EDITOR_VERSION="2020.3.27f1"
SDK_ROOT="/Applications/Unity/Hub/Editor/${EDITOR_VERSION}/PlaybackEngines/AndroidPlayer/SDK"

# JAVA_HOME
export JAVA_HOME="/Applications/Unity/Hub/Editor/${EDITOR_VERSION}/PlaybackEngines/AndroidPlayer/OpenJDK/jre"

# Accept License
"${SDK_ROOT}/tools/bin/sdkmanager" "platforms;android-28" --sdk_root=${SDK_ROOT}
```

## Firebase

To integrate the Firebase SDK, go through the following steps:

1. Create Firebase account.
2. Create Firebase project.
3. Add your apps to the project.
4. Download the `google-services.json` (Android) and `GoogleService-Info.plist` (iOS).
5. Add the above files to the **Assets** folder on Unity.
6. Download [Firebase SDK 8.6.2](https://dl.google.com/firebase/sdk/unity/firebase_unity_sdk_8.6.2.zip)(latest tested version by Skillz at the time of writing). Any new update under the same major Firebase version should be compatible.

Follow the steps in the [Get started with Firebase Crashlytics](https://firebase.google.com/docs/crashlytics/get-started?platform=unity) guide to integrate Unity.

* The code in **Step 2** and **Step 5** has already been added in **Assets** folder in all of the Driver templates under the name of `CrashlyticsInit.cs` and `CrashlyticsTester.cs` and have been assigned to the `CrashlyticsInitializer` and `CrashlyticsTestCrash` GameObjects, respectively.
  * To use the code, you just need to comment it out.

## Debugging

If you are having issues, try the following:

* Close Unity and Unity Hub.
* Delete the `Library` and `Temp` folders.
* Open Unity again and open Project.

The above will rebuild the project from scratch, hopefully fixing all the dependency issues.
