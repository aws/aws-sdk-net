/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Configuration information for a Amazon Lookout for Vision model packaging job. For
    /// more information, see <a>StartModelPackagingJob</a>.
    /// </summary>
    public partial class ModelPackagingConfiguration
    {
        private GreengrassConfiguration _greengrass;

        /// <summary>
        /// Gets and sets the property Greengrass. 
        /// <para>
        ///  Configuration information for the AWS IoT Greengrass component in a model packaging
        /// job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GreengrassConfiguration Greengrass
        {
            get { return this._greengrass; }
            set { this._greengrass = value; }
        }

        // Check to see if Greengrass property is set
        internal bool IsSetGreengrass()
        {
            return this._greengrass != null;
        }

    }
}