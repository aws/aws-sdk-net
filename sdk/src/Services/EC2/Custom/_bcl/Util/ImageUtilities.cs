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

#pragma warning disable 1591

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This class has utility methods for finding common Amazon machine images.
    /// </summary>
    public static class ImageUtilities
    {
        #region ImageKeys

        public const string WINDOWS_2012R2_BASE_KEY = "WINDOWS_2012R2_BASE";

        public const string WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014_KEY = "WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014";
        public const string WINDOWS_2012R2_SQL_SERVER_STANDARD_2014_KEY = "WINDOWS_2012R2_SQL_SERVER_STANDARD_2014";
        public const string WINDOWS_2012R2_SQL_SERVER_WEB_2014_KEY = "WINDOWS_2012R2_SQL_SERVER_WEB_2014";

        public const string WINDOWS_2012_BASE_KEY = "WINDOWS_2012_BASE";

        public const string WINDOWS_2012_SQL_SERVER_EXPRESS_2014_KEY = "WINDOWS_2012_SQL_SERVER_EXPRESS_2014";
        public const string WINDOWS_2012_SQL_SERVER_STANDARD_2014_KEY = "WINDOWS_2012_SQL_SERVER_STANDARD_2014";
        public const string WINDOWS_2012_SQL_SERVER_WEB_2014_KEY = "WINDOWS_2012_SQL_SERVER_WEB_2014";

        public const string WINDOWS_2012_SQL_SERVER_EXPRESS_2012_KEY = "WINDOWS_2012_SQL_SERVER_EXPRESS_2012";
        public const string WINDOWS_2012_SQL_SERVER_STANDARD_2012_KEY = "WINDOWS_2012_SQL_SERVER_STANDARD_2012";
        public const string WINDOWS_2012_SQL_SERVER_WEB_2012_KEY = "WINDOWS_2012_SQL_SERVER_WEB_2012";

        public const string WINDOWS_2012_SQL_SERVER_EXPRESS_2008_KEY = "WINDOWS_2012_SQL_SERVER_EXPRESS_2008";
        public const string WINDOWS_2012_SQL_SERVER_STANDARD_2008_KEY = "WINDOWS_2012_SQL_SERVER_STANDARD_2008";
        public const string WINDOWS_2012_SQL_SERVER_WEB_2008_KEY = "WINDOWS_2012_SQL_SERVER_WEB_2008";

        public const string WINDOWS_2008R2_BASE_KEY = "WINDOWS_2008R2_BASE";

        public const string WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012_KEY = "WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012";
        public const string WINDOWS_2008R2_SQL_SERVER_STANDARD_2012_KEY = "WINDOWS_2008R2_SQL_SERVER_STANDARD_2012";
        public const string WINDOWS_2008R2_SQL_SERVER_WEB_2012_KEY = "WINDOWS_2008R2_SQL_SERVER_WEB_2012";

        public const string WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008_KEY = "WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008";
        public const string WINDOWS_2008R2_SQL_SERVER_STANDARD_2008_KEY = "WINDOWS_2008R2_SQL_SERVER_STANDARD_2008";
        public const string WINDOWS_2008R2_SQL_SERVER_WEB_2008_KEY = "WINDOWS_2008R2_SQL_SERVER_WEB_2008";

        public const string WINDOWS_2008RTM_BASE_KEY = "WINDOWS_2008RTM_BASE";

        public const string WINDOWS_2008RTM_SQL_SERVER_EXPRESS_2008_KEY = "WINDOWS_2008RTM_SQL_SERVER_EXPRESS_2008";
        public const string WINDOWS_2008RTM_SQL_SERVER_STANDARD_2008_KEY = "WINDOWS_2008RTM_SQL_SERVER_STANDARD_2008";

        public const string WINDOWS_2008_BEANSTALK_IIS75_KEY = "WINDOWS_2008_BEANSTALK_IIS75";
        public const string WINDOWS_2012_BEANSTALK_IIS8_KEY = "WINDOWS_2012_BEANSTALK_IIS8";

        public const string VPC_NAT_KEY = "VPC_NAT";

        /// <summary>
        /// The collection of keys that can be used to address images.
        /// </summary>
        public static readonly IEnumerable<string> ImageKeys = new string[]
        {
            WINDOWS_2012R2_BASE_KEY,
            WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014_KEY,
            WINDOWS_2012R2_SQL_SERVER_STANDARD_2014_KEY,
            WINDOWS_2012R2_SQL_SERVER_WEB_2014_KEY,
            WINDOWS_2012_BASE_KEY,
            WINDOWS_2012_SQL_SERVER_EXPRESS_2014_KEY,
            WINDOWS_2012_SQL_SERVER_STANDARD_2014_KEY,
            WINDOWS_2012_SQL_SERVER_WEB_2014_KEY,
            WINDOWS_2012_SQL_SERVER_EXPRESS_2012_KEY,
            WINDOWS_2012_SQL_SERVER_STANDARD_2012_KEY,
            WINDOWS_2012_SQL_SERVER_WEB_2012_KEY,
            WINDOWS_2012_SQL_SERVER_EXPRESS_2008_KEY,
            WINDOWS_2012_SQL_SERVER_STANDARD_2008_KEY,
            WINDOWS_2012_SQL_SERVER_WEB_2008_KEY,
            WINDOWS_2008R2_BASE_KEY,
            WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012_KEY,
            WINDOWS_2008R2_SQL_SERVER_STANDARD_2012_KEY,
            WINDOWS_2008R2_SQL_SERVER_WEB_2012_KEY,
            WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008_KEY,
            WINDOWS_2008R2_SQL_SERVER_STANDARD_2008_KEY,
            WINDOWS_2008R2_SQL_SERVER_WEB_2008_KEY,
            WINDOWS_2008RTM_BASE_KEY,
            WINDOWS_2008RTM_SQL_SERVER_EXPRESS_2008_KEY,
            WINDOWS_2008RTM_SQL_SERVER_STANDARD_2008_KEY,
            WINDOWS_2008_BEANSTALK_IIS75_KEY,
            WINDOWS_2012_BEANSTALK_IIS8_KEY,
            VPC_NAT_KEY 
        };

        #endregion

        #region Windows 2012 R2 Images

        public static readonly ImageDescriptor WINDOWS_2012R2_BASE = new ImageDescriptor(WINDOWS_2012R2_BASE_KEY);

        public static readonly ImageDescriptor WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014 = new ImageDescriptor(WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014_KEY);
        public static readonly ImageDescriptor WINDOWS_2012R2_SQL_SERVER_STANDARD_2014 = new ImageDescriptor(WINDOWS_2012R2_SQL_SERVER_STANDARD_2014_KEY);
        public static readonly ImageDescriptor WINDOWS_2012R2_SQL_SERVER_WEB_2014 = new ImageDescriptor(WINDOWS_2012R2_SQL_SERVER_WEB_2014_KEY);

        #endregion

        #region Windows 2012 (Original RTM) Images

        public static readonly ImageDescriptor WINDOWS_2012_BASE = new ImageDescriptor(WINDOWS_2012_BASE_KEY);

        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2014 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_EXPRESS_2014_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2014 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_STANDARD_2014_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2014 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_WEB_2014_KEY);

        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2012 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_EXPRESS_2012_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2012 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_STANDARD_2012_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2012 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_WEB_2012_KEY);
        
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2008 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_EXPRESS_2008_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2008 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_STANDARD_2008_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2008 = new ImageDescriptor(WINDOWS_2012_SQL_SERVER_WEB_2008_KEY);

        #endregion

        #region Windows 2008 R2 Images

        public static readonly ImageDescriptor WINDOWS_2008R2_BASE = new ImageDescriptor(WINDOWS_2008R2_BASE_KEY);

        public static readonly ImageDescriptor WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012 = new ImageDescriptor(WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012_KEY);
        public static readonly ImageDescriptor WINDOWS_2008R2_SQL_SERVER_STANDARD_2012 = new ImageDescriptor(WINDOWS_2008R2_SQL_SERVER_STANDARD_2012_KEY);
        public static readonly ImageDescriptor WINDOWS_2008R2_SQL_SERVER_WEB_2012 = new ImageDescriptor(WINDOWS_2008R2_SQL_SERVER_WEB_2012_KEY);

        public static readonly ImageDescriptor WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008 = new ImageDescriptor(WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008_KEY);
        public static readonly ImageDescriptor WINDOWS_2008R2_SQL_SERVER_STANDARD_2008 = new ImageDescriptor(WINDOWS_2008R2_SQL_SERVER_STANDARD_2008_KEY);
        public static readonly ImageDescriptor WINDOWS_2008R2_SQL_SERVER_WEB_2008 = new ImageDescriptor(WINDOWS_2008R2_SQL_SERVER_WEB_2008_KEY);

        #endregion

        #region Windows 2008 (Original RTM) Images

        public static readonly ImageDescriptor WINDOWS_2008RTM_BASE = new ImageDescriptor(WINDOWS_2008RTM_BASE_KEY);

        public static readonly ImageDescriptor WINDOWS_2008RTM_SQL_SERVER_EXPRESS_2008 = new ImageDescriptor(WINDOWS_2008RTM_SQL_SERVER_EXPRESS_2008_KEY);
        public static readonly ImageDescriptor WINDOWS_2008RTM_SQL_SERVER_STANDARD_2008 = new ImageDescriptor(WINDOWS_2008RTM_SQL_SERVER_STANDARD_2008_KEY);

        #endregion

        #region Misc Images

        public static readonly ImageDescriptor WINDOWS_2008_BEANSTALK_IIS75 = new ImageDescriptor(WINDOWS_2008_BEANSTALK_IIS75_KEY);
        public static readonly ImageDescriptor WINDOWS_2012_BEANSTALK_IIS8 = new ImageDescriptor(WINDOWS_2012_BEANSTALK_IIS8_KEY);

        public static readonly ImageDescriptor VPC_NAT = new ImageDescriptor(VPC_NAT_KEY);

        #endregion

        #region Obsolete Members

        [Obsolete("Please use the WINDOWS_2012_SQL_SERVER_EXPRESS_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2008_R2 = WINDOWS_2012_SQL_SERVER_EXPRESS_2008;
        [Obsolete("Please use the WINDOWS_2012_SQL_SERVER_STANDARD_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2008_R2 = WINDOWS_2012_SQL_SERVER_STANDARD_2008;
        [Obsolete("Please use the WINDOWS_2012_SQL_SERVER_WEB_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2008_R2 = WINDOWS_2012_SQL_SERVER_WEB_2008;
        [Obsolete("Please use the WINDOWS_2012_SQL_SERVER_EXPRESS_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2008_R2_SP2 = WINDOWS_2012_SQL_SERVER_EXPRESS_2008;
        [Obsolete("Please use the WINDOWS_2012_SQL_SERVER_STANDARD_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2008_R2_SP2 = WINDOWS_2012_SQL_SERVER_STANDARD_2008;
        [Obsolete("Please use the WINDOWS_2012_SQL_SERVER_WEB_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2008_R2_SP2 = WINDOWS_2012_SQL_SERVER_WEB_2008;

        [Obsolete("Please use the WINDOWS_2008R2_BASE member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_BASE = WINDOWS_2008R2_BASE;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_EXPRESS_2012 = WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_STANDARD_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_STANDARD_2012 = WINDOWS_2008R2_SQL_SERVER_STANDARD_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_WEB_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_WEB_2012 = WINDOWS_2008R2_SQL_SERVER_WEB_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_EXPRESS_2008_R2_SP2 = WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_STANDARD_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_STANDARD_2008_R2_SP2 = WINDOWS_2008R2_SQL_SERVER_STANDARD_2008;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_WEB_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_WEB_2008_R2_SP2 = WINDOWS_2008R2_SQL_SERVER_WEB_2008;
        
        [Obsolete("Please use the WINDOWS_2008R2_BASE member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_BASE = WINDOWS_2008R2_BASE;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SQL_SERVER_EXPRESS_2012 = WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_STANDARD_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SQL_SERVER_STANDARD_2012 = WINDOWS_2008R2_SQL_SERVER_STANDARD_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_WEB_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SQL_SERVER_WEB_2012 = WINDOWS_2008R2_SQL_SERVER_WEB_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SQL_SERVER_EXPRESS_2008_R2 = WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_STANDARD_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SQL_SERVER_STANDARD_2008_R2 = WINDOWS_2008R2_SQL_SERVER_STANDARD_2008;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_WEB_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_R2_SQL_SERVER_WEB_2008_R2 = WINDOWS_2008R2_SQL_SERVER_WEB_2008;

        // Legacy keys kept for backwards compatibility with user-code so the R2 ami gets served, now that we also have 2008RTM amis
        // in the collection
        [Obsolete("Please use the WINDOWS_2008R2_BASE member.")]
        public static readonly ImageDescriptor WINDOWS_2008_BASE = WINDOWS_2008R2_BASE;

        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_SQL_SERVER_EXPRESS_2012 = WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_STANDARD_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_SQL_SERVER_STANDARD_2012 = WINDOWS_2008R2_SQL_SERVER_STANDARD_2012;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_WEB_2012 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_SQL_SERVER_WEB_2012 = WINDOWS_2008R2_SQL_SERVER_WEB_2012;

        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_SQL_SERVER_EXPRESS_2008 = WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_STANDARD_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_SQL_SERVER_STANDARD_2008 = WINDOWS_2008R2_SQL_SERVER_STANDARD_2008;
        [Obsolete("Please use the WINDOWS_2008R2_SQL_SERVER_WEB_2008 member.")]
        public static readonly ImageDescriptor WINDOWS_2008_SQL_SERVER_WEB_2008 = WINDOWS_2008R2_SQL_SERVER_WEB_2008;

        #endregion

        #region Initialization and private members

        static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(ImageUtilities));
            }
        }

        private static readonly ImageDescriptor[] WindowsDescriptors =
        {
            WINDOWS_2012R2_BASE,

            WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014,
            WINDOWS_2012R2_SQL_SERVER_STANDARD_2014,
            WINDOWS_2012R2_SQL_SERVER_WEB_2014,
            
            WINDOWS_2012_BASE,

            WINDOWS_2012_SQL_SERVER_EXPRESS_2014,
            WINDOWS_2012_SQL_SERVER_STANDARD_2014,
            WINDOWS_2012_SQL_SERVER_WEB_2014,

            WINDOWS_2012_SQL_SERVER_EXPRESS_2012,
            WINDOWS_2012_SQL_SERVER_STANDARD_2012,
            WINDOWS_2012_SQL_SERVER_WEB_2012,
            
            WINDOWS_2012_SQL_SERVER_EXPRESS_2008,
            WINDOWS_2012_SQL_SERVER_STANDARD_2008,
            WINDOWS_2012_SQL_SERVER_WEB_2008,
            
            WINDOWS_2008R2_BASE,
            
            WINDOWS_2008R2_SQL_SERVER_EXPRESS_2012,
            WINDOWS_2008R2_SQL_SERVER_STANDARD_2012,
            WINDOWS_2008R2_SQL_SERVER_WEB_2012,
            
            WINDOWS_2008R2_SQL_SERVER_EXPRESS_2008,
            WINDOWS_2008R2_SQL_SERVER_STANDARD_2008,
            WINDOWS_2008R2_SQL_SERVER_WEB_2008,
            
            WINDOWS_2008RTM_BASE,
            
            WINDOWS_2008RTM_SQL_SERVER_EXPRESS_2008,
            WINDOWS_2008RTM_SQL_SERVER_STANDARD_2008,

            WINDOWS_2008_BEANSTALK_IIS75,
            WINDOWS_2012_BEANSTALK_IIS8
        };

        private static readonly ImageDescriptor[] LinuxDescriptors =
        {
            VPC_NAT
        };

        private const string CLOUDFRONT_LOCATION_OF_AMI_FILE = "http://aws-sdk-configurations.amazonwebservices.com/stockamis.json";
        private const string S3_LOCATION_OF_AMI_FILE = "https://aws-sdk-configurations.s3.amazonaws.com/stockamis.json";

        private const string WindowsImagesTag = "WindowsImages";
        private const string LinuxImagesTag = "LinuxImages";
        private const string DefinitionKeyTag = "key";
        private const string DefinitionPrefixTag = "prefix";

        private const int MAX_DOWNLOAD_RETRIES = 3;

        private static readonly object LOCK_OBJECT = new object();

        static ImageUtilities()
        {
            LoadDefinitionsFromWeb();
        }

        static void LoadDefinitionsFromWeb()
        {
            int retries = 0;
            while (retries < MAX_DOWNLOAD_RETRIES)
            {
                try
                {
                    HttpWebResponse response = null;
                    try
                    {
                        var request = WebRequest.Create(CLOUDFRONT_LOCATION_OF_AMI_FILE) as HttpWebRequest;
                        response = request.GetResponse() as HttpWebResponse;
                    }
                    catch (Exception)
                    {
                        var request = WebRequest.Create(S3_LOCATION_OF_AMI_FILE) as HttpWebRequest;
                        response = request.GetResponse() as HttpWebResponse;
                    }

                    using (response)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            lock (LOCK_OBJECT)
                            {
                                ParseAMIDefinitions(reader);
                                return;
                            }
                        }
                    }
                }
                catch (WebException e)
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
                Thread.Sleep(delay);
            }
        }

        /// <summary>
        /// Parses the ami definition content into the ImageDescriptor members. 
        /// </summary>
        /// <param name="reader">A reader of the ami definitions</param>
        private static void ParseAMIDefinitions(StreamReader reader)
        {
            try
            {
                var jdata = JsonMapper.ToObject(reader);

                var platformTags = new string[]
            {
                WindowsImagesTag,
                LinuxImagesTag
            };

                var parsedDefinitionsMap = new Dictionary<string, string>();
                foreach (var platformTag in platformTags)
                {
                    var imageDefinitions = jdata[platformTag];
                    if (imageDefinitions == null)
                    {
                        Logger.InfoFormat("Parsing AMI definitions - did not find any images for platform tag '{0}'", platformTag);
                        continue;
                    }

                    for (int d = 0; d < imageDefinitions.Count; d++)
                    {
                        var def = imageDefinitions[d];
                        var key = (string)def[DefinitionKeyTag];
                        var prefix = (string)def[DefinitionPrefixTag];

                        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(prefix))
                            parsedDefinitionsMap[key] = prefix;
                        else
                            Logger.InfoFormat("Parsing AMI definitions - found malformed descriptor entry for definition index {0} in platform group {1}, discarded", d, platformTag);
                    }
                }

                foreach (var d in WindowsDescriptors)
                {
                    if (parsedDefinitionsMap.ContainsKey(d.DefinitionKey))
                        d.NamePrefix = parsedDefinitionsMap[d.DefinitionKey];
                    else
                        Logger.InfoFormat("Parsing AMI definitions - did not find entry for Windows image descriptor '{0}' after parsing", d.DefinitionKey);
                }

                foreach (var d in LinuxDescriptors)
                {
                    if (parsedDefinitionsMap.ContainsKey(d.DefinitionKey))
                        d.NamePrefix = parsedDefinitionsMap[d.DefinitionKey];
                    else
                        Logger.InfoFormat("Parsing AMI definitions - did not find entry for Linux image descriptor '{0}' after parsing", d.DefinitionKey);
                }
            }
            catch (Exception e)
            {
                Logger.Error(e, "Exception whilst parsing AMI definitions file.");
            }
        }

        #endregion

        /// <summary>
        /// Returns the ImageDescriptor instance for a known key.
        /// </summary>
        /// <param name="key">The version-independent key identifying the descriptor</param>
        /// <returns>Matching descriptor containing the name filter to search on</returns>
        public static ImageDescriptor DescriptorFromKey(string key)
        {
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

        /// <summary>
        /// Find the Amazon machine image identified by the version-independent key name.
        /// </summary>
        /// <param name="ec2Client">The EC2 client used to search for the image.</param>
        /// <param name="imageKey">The keyname used to identify the image.</param>
        /// <returns>The Amazon machine image.</returns>
        public static Image FindImage(IAmazonEC2 ec2Client, string imageKey)
        {
            ImageDescriptor descriptor = DescriptorFromKey(imageKey);

            if (descriptor != null)
                return FindImage(ec2Client, descriptor);
            else
                throw new ArgumentException("Image key '{ 0}' is not recognized.", imageKey);
        }

        /// <summary>
        /// Find the Amazon machine image identified by the ImageDescriptor.
        /// </summary>
        /// <param name="ec2Client">The EC2 client used to search for the image.</param>
        /// <param name="descriptor">The descriptor used to identify the image.</param>
        /// <returns>The Amazon machine image.</returns>
        public static Image FindImage(IAmazonEC2 ec2Client, ImageDescriptor descriptor)
        {
            if (ec2Client == null)
                throw new ArgumentNullException("ec2Client");
            if (descriptor == null)
                throw new ArgumentNullException("descriptor");

            int retryCount = 1;
            Image image = null;
            do
            {
                var result = ec2Client.DescribeImages(new DescribeImagesRequest()
                {
                    Owners = new List<string>() { "amazon" },
                    Filters = new List<Filter>()
                {
                    new Filter(){Name = "name", Values = new List<string>(){descriptor.NamePrefix}}
                }
                });

                if (result.Images.Count != 0)
                    image = result.Images.OrderByDescending(x => x.Name).First();
                else
                {
                    // backing control file may be outdated, reload and try once more
                    if (retryCount == 1)
                    {
                        Logger.InfoFormat("FindImage - DescribeImages call for image descriptor '{0}' (name prefix '{1}') yielded no results, assuming outdated control file and reloading", 
                                          descriptor.DefinitionKey,
                                          descriptor.NamePrefix);
                        LoadDefinitionsFromWeb();
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

        /// <summary>
        /// This class identifies an image that will be looked up using a logical
        /// key independent of release (RTM) or service pack (SPx) designations,
        /// always returning the latest version of an image.
        /// </summary>
        public class ImageDescriptor
        {            
            internal ImageDescriptor(string definitionKey)
            {
                this.DefinitionKey = definitionKey;
            }

            /// <summary>
            /// The logical name assigned to this image in the backing definitions file.
            /// This key is independent of RTM/service pack number.
            /// </summary>
            public string DefinitionKey
            {
                get; 
                private set;
            }

            /// <summary>
            /// The name prefix or pattern of the Amazon machine image that will be looked up.
            /// </summary>
            public string NamePrefix
            {
                get;
                internal set;
            }

            /// <summary>
            /// Override to return back the NamePrefix
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return this.NamePrefix;
            }
        }
    }
}
