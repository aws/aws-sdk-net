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
    /// Information about the AWS IoT Greengrass component created by a model packaging job.
    /// </summary>
    public partial class GreengrassOutputDetails
    {
        private string _componentName;
        private string _componentVersion;
        private string _componentVersionArn;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        ///  The name of the component. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        ///  The version of the component. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ComponentVersion
        {
            get { return this._componentVersion; }
            set { this._componentVersion = value; }
        }

        // Check to see if ComponentVersion property is set
        internal bool IsSetComponentVersion()
        {
            return this._componentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersionArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the component. 
        /// </para>
        /// </summary>
        public string ComponentVersionArn
        {
            get { return this._componentVersionArn; }
            set { this._componentVersionArn = value; }
        }

        // Check to see if ComponentVersionArn property is set
        internal bool IsSetComponentVersionArn()
        {
            return this._componentVersionArn != null;
        }

    }
}