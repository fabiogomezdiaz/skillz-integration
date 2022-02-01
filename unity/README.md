# Implementations

```bash
# Go to implementations folder
cd unity/implementations

# Copy one of your desired games. For example Driver-2019.4.34f1
GAME_NAME="Driver-2019.4.34f1"
SDK_VERSION="27.2.8"
cp -r "../_game-templates/${GAME_NAME}" "./${GAME_NAME}-SDK-${SDK_VERSION}"

# Go to your game directory
cd "./${GAME_NAME}-SDK-${SDK_VERSION}"

# Remove any environment specific files
#rm -rf .vscode Library Temp
```
