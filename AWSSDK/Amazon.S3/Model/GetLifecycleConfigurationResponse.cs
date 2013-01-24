/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The DeleteObjectsResponse contains a list of successful
    /// and failed deletes, as well as any headers returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class GetLifecycleConfigurationResponse : S3Response
    {
        private LifecycleConfiguration configuration;

        /// <summary>
        /// Gets and Sets the property that governs whether
        /// the response includes successful deletes as well as errors
        /// following the DeleteObjects call against S3.
        /// 
        /// By default this property is false and successful deletes
        /// are returned in the response.
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }
    }
}