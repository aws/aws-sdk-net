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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about the latest version of a component.
    /// </summary>
    public partial class ComponentLatestVersion
    {
        private string _arn;
        private string _componentVersion;
        private DateTime? _creationTimestamp;
        private string _description;
        private List<ComponentPlatform> _platforms = AWSConfigs.InitializeCollections ? new List<ComponentPlatform>() : null;
        private string _publisher;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the component version.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
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
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the component was created, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// The platforms that the component version supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentPlatform> Platforms
        {
            get { return this._platforms; }
            set { this._platforms = value; }
        }

        // Check to see if Platforms property is set
        internal bool IsSetPlatforms()
        {
            return this._platforms != null && (this._platforms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// The publisher of the component version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }

        // Check to see if Publisher property is set
        internal bool IsSetPublisher()
        {
            return this._publisher != null;
        }

    }
}