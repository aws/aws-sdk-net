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
using System.Linq;
using System.Text;

using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This class has utility methods for finding Amazon machine images.
    /// </summary>
    public static class ImageUtilities
    {
        public readonly static ImageDescriptor WINDOWS_2012_BASE = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-Base*");
        public readonly static ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2012 = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-SQL_2012_RTM_Express*");
        public readonly static ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2012 = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-SQL_2012_RTM_Standard*");
        public readonly static ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2012 = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-SQL_2012_RTM_Web*");
        public readonly static ImageDescriptor WINDOWS_2012_SQL_SERVER_EXPRESS_2008_R2_SP2 = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-SQL_2008_R2_SP2_Express*");
        public readonly static ImageDescriptor WINDOWS_2012_SQL_SERVER_STANDARD_2008_R2_SP2 = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-SQL_2008_R2_SP2_Standard*");
        public readonly static ImageDescriptor WINDOWS_2012_SQL_SERVER_WEB_2008_R2_SP2 = new ImageDescriptor("Windows_Server-2012-RTM-English-64Bit-SQL_2008_R2_SP2_Web*");

        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_BASE = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-Base*");
        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_EXPRESS_2012 = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-SQL_2012_RTM_Express*");
        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_STANDARD_2012 = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-SQL_2012_RTM_Standard*");
        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_WEB_2012 = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-SQL_2012_RTM_Web*");
        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_EXPRESS_2008_R2_SP2 = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-SQL_2008_R2_SP2_Express*");
        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_STANDARD_2008_R2_SP2 = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-SQL_2008_R2_SP2_Standard*");
        public readonly static ImageDescriptor WINDOWS_2008_R2_SP1_SQL_SERVER_WEB_2008_R2_SP2 = new ImageDescriptor("Windows_Server-2008-R2_SP1-English-64Bit-SQL_2008_R2_SP2_Web*");

        public readonly static ImageDescriptor VPC_NAT = new ImageDescriptor("ami-vpc-nat-*.x86_64-ebs");



        /// <summary>
        /// Find the Amazon machine image identified by the ImageDescriptor
        /// </summary>
        /// <param name="ec2Client">The EC2 client used to search for the image.</param>
        /// <param name="descriptor">The descriptor used to identify the image.</param>
        /// <returns>The Amazon machine image.</returns>
        public static Image FindImage(AmazonEC2 ec2Client, ImageDescriptor descriptor)
        {
            if (ec2Client == null)
                throw new ArgumentNullException("ec2Client");
            if (descriptor == null)
                throw new ArgumentNullException("descriptor");

            var result = ec2Client.DescribeImages(new DescribeImagesRequest()
            {
                Owner = new List<string>() { "amazon" },
                Filter = new List<Filter>()
                {
                    new Filter(){Name = "name", Value = new List<string>(){descriptor.NamePrefix}}
                }
            }).DescribeImagesResult;

            if (result.Image.Count == 0)
                return null;

            var image = result.Image.OrderByDescending(x => x.Name).First();
            return image;
        }

        /// <summary>
        /// This class identifies an image that will be looked up.
        /// </summary>
        public class ImageDescriptor
        {            
            internal ImageDescriptor(string nameprefix)
            {
                this.NamePrefix = nameprefix;
            }

            /// <summary>
            /// Gets the name prefix of the Amazon machine image that will be looked up.
            /// </summary>
            public string NamePrefix
            {
                get;
                private set;
            }

            public override string ToString()
            {
                return this.NamePrefix;
            }
        }
    }
}
