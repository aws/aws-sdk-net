/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Util;

using ThirdParty.Json.LitJson;
using Amazon.Runtime;
using System.Threading.Tasks;

#pragma warning disable 1591

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This class has utility methods for finding common Amazon machine images.
    /// </summary>
    public static partial class ImageUtilities
    {
        /// <summary>
        /// Returns the ImageDescriptor instance for a known key.
        /// </summary>
        /// <param name="key">The version-independent key identifying the descriptor</param>
        /// <returns>Matching descriptor containing the name filter to search on</returns>
        public static Task<ImageDescriptor> DescriptorFromKeyAsync(string key)
        {
            return DescriptorFromKeyAsync(key, null);
        }

        /// <summary>
        /// Returns the ImageDescriptor instance for a known key.
        /// </summary>
        /// <param name="key">
        /// The version-independent key identifying the descriptor
        /// </param>
        /// <param name="ec2Client">
        /// <para>
        /// Optional. Configured client object from which proxy settings, if needed, can be
        /// determined. If no client is supplied the application configuration will be 
        /// inspected for proxy details. 
        /// </para>
        /// <para>
        /// If a proxy is configured (either on the client or in the configuration file) it
        /// will be used when downloading the metadata file containing the key to filter 
        /// mappings.
        /// </para>
        /// </param>
        /// <returns>Matching descriptor containing the name filter to search on</returns>
        public static async Task<ImageDescriptor> DescriptorFromKeyAsync(string key, IAmazonEC2 ec2Client)
        {
            await LoadDefinitionsFromWebAsync(ConfigFromClient(ec2Client)).ConfigureAwait(false);

            foreach (var d in WindowsDescriptors)
            {
                if (d.DefinitionKey.Equals(key, StringComparison.OrdinalIgnoreCase))
                    return d;
            }

            foreach (var d in LinuxDescriptors)
            {
                if (d.DefinitionKey.Equals(key, StringComparison.OrdinalIgnoreCase))
                    return d;
            }

            return null;
        }
        
        private static async Task LoadDefinitionsFromWebAsync(AmazonEC2Config ec2Config)
        {
            lock (LOCK_OBJECT)
            {
                if (ImageDefinitionsLoaded)
                    return;
            }

            IWebProxy webProxy = null;
            if (ec2Config != null)
                webProxy = ec2Config.GetWebProxy();

            int retries = 0;
            while (retries < MAX_DOWNLOAD_RETRIES)
            {
                try
                {
                    HttpWebResponse response = null;
                    foreach (var location in DownloadLocations)
                    {
                        try
                        {
                            response = await DownloadControlFileAsync(location, webProxy).ConfigureAwait(false);
                            if (response != null)
                                break;
                        }
                        catch (Exception e)
                        {
                            Logger.InfoFormat("Failed to download stockamis.json from {0}, exception {1}", location, e);
                        }
                    }

                    if (response == null)
                        throw new AmazonClientException("Failed to download ImageUtilities metadata file stockamis.json from known locations.");

                    using (response)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            lock (LOCK_OBJECT)
                            {
                                ParseAMIDefinitions(reader);
                                ImageDefinitionsLoaded = true;

                                return;
                            }
                        }
                    }
                }
                catch (AmazonClientException e)
                {
                    retries++;
                    if (retries == MAX_DOWNLOAD_RETRIES)
                    {
                        Logger.Error(e, "Error downloading AMI definition file, ImageDescriptors were not initialized.");
                        break;
                    }
                }

                int delay = (int)(Math.Pow(4, retries) * 100);
                delay = Math.Min(delay, 30 * 1000);
                await Task.Delay(delay);
            }
        }
        private static async Task<HttpWebResponse> DownloadControlFileAsync(string location, IWebProxy proxy)
        {
            var request = WebRequest.Create(location) as HttpWebRequest;
            if (proxy != null)
                request.Proxy = proxy;
            return await request.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse;
        }

        /// <summary>
        /// Find the Amazon machine image identified by the version-independent key name.
        /// </summary>
        /// <param name="ec2Client">The EC2 client used to search for the image.</param>
        /// <param name="imageKey">The keyname used to identify the image.</param>
        /// <returns>The Amazon machine image.</returns>
        public static async Task<Image> FindImageAsync(IAmazonEC2 ec2Client, string imageKey)
        {
            ImageDescriptor descriptor = await DescriptorFromKeyAsync(imageKey).ConfigureAwait(false);

            if (descriptor != null)
                return await FindImageAsync(ec2Client, descriptor).ConfigureAwait(false);
            else
                throw new ArgumentException("Image key '{0}' is not recognized.", imageKey);
        }

        /// <summary>
        /// Find the Amazon machine image identified by the ImageDescriptor.
        /// </summary>
        /// <param name="ec2Client">The EC2 client used to search for the image.</param>
        /// <param name="descriptor">The descriptor used to identify the image.</param>
        /// <returns>The Amazon machine image.</returns>
        public static async Task<Image> FindImageAsync(IAmazonEC2 ec2Client, ImageDescriptor descriptor)
        {
            if (ec2Client == null)
                throw new ArgumentNullException("ec2Client");
            if (descriptor == null)
                throw new ArgumentNullException("descriptor");

            var config = ConfigFromClient(ec2Client);
            await LoadDefinitionsFromWebAsync(config).ConfigureAwait(false);

            int retryCount = 1;
            Image image = null;
            do
            {
                var result = await ec2Client.DescribeImagesAsync(new DescribeImagesRequest()
                {
                    Owners = new List<string>() { "amazon" },
                    Filters = new List<Filter>()
                {
                    new Filter(){Name = "name", Values = new List<string>(){descriptor.NamePrefix}}
                }
                }).ConfigureAwait(false);

                if (result.Images.Any())
                    image = result.Images.OrderByDescending(x => x.Name).First();
                else
                {
                    // backing control file may be outdated, reload and try once more
                    if (retryCount == 1)
                    {
                        Logger.InfoFormat("FindImage - DescribeImages call for image descriptor '{0}' (name prefix '{1}') yielded no results, assuming outdated control file and reloading",
                                          descriptor.DefinitionKey,
                                          descriptor.NamePrefix);
                        lock (LOCK_OBJECT)
                        {
                            ImageDefinitionsLoaded = false;
                        }

                        await LoadDefinitionsFromWebAsync(config).ConfigureAwait(false);
                    }
                    retryCount++;
                }
            } while (image == null && retryCount <= 2);

            if (image == null)
                Logger.InfoFormat("FindImage - failed to find valid AMI image for descriptor '{0}' (name prefix '{1}')",
                                  descriptor.DefinitionKey,
                                  descriptor.NamePrefix);

            return image;
        }
    }
}
