      public readonly Texture2D GetSteamPFP(int iImage)
        {
            if (iImage == -1)
            {
                MonkeLogger.Log(level: MonkeLogger.LogLevel.Illegal, log: "Steam returned a PFP value of -1. This is illegal.");
                return null;
            }
            Texture2D texture = null;

            bool isValid = SteamUtils.GetImageSize(iImage, out uint width, out uint height);

            if (isValid)
            {
                byte[] image = new byte[width * height * 4];

                isValid = SteamUtils.GetImageRGBA(iImage, image, (int)(width * height * 4));

                if (isValid)
                {
                    texture = new Texture2D((int)width, (int)height, TextureFormat.RGBA32, false, true);
                    texture.LoadRawTextureData(image);
                    texture.Apply();
                }
            }

            return texture;
        }

public readonly Texture2D GetSteamPFP(CSteamID steamID)
        {
            int iImage = SteamFriends.GetLargeFriendAvatar(steamID);
            if (iImage == -1)
            {
                MonkeLogger.Log(level: MonkeLogger.LogLevel.Illegal, log: "Steam returned a PFP value of -1. This is illegal.");
                return null;
            }
            Texture2D texture = null;

            bool isValid = SteamUtils.GetImageSize(iImage, out uint width, out uint height);

            if (isValid)
            {
                byte[] image = new byte[width * height * 4];

                isValid = SteamUtils.GetImageRGBA(iImage, image, (int)(width * height * 4));

                if (isValid)
                {
                    texture = new Texture2D((int)width, (int)height, TextureFormat.RGBA32, false, true);
                    texture.LoadRawTextureData(image);
                    texture.Apply();
                }
            }

            return texture;
        }
