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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplicationInstance operation.
    /// Creates an application instance and deploys it to a device.
    /// </summary>
    public partial class CreateApplicationInstanceRequest : AmazonPanoramaRequest
    {
        private string _applicationInstanceIdToReplace;
        private string _defaultRuntimeContextDevice;
        private string _description;
        private ManifestOverridesPayload _manifestOverridesPayload;
        private ManifestPayload _manifestPayload;
        private string _name;
        private string _runtimeRoleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationInstanceIdToReplace. 
        /// <para>
        /// The ID of an application instance to replace with the new instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ApplicationInstanceIdToReplace
        {
            get { return this._applicationInstanceIdToReplace; }
            set { this._applicationInstanceIdToReplace = value; }
        }

        // Check to see if ApplicationInstanceIdToReplace property is set
        internal bool IsSetApplicationInstanceIdToReplace()
        {
            return this._applicationInstanceIdToReplace != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRuntimeContextDevice. 
        /// <para>
        /// A device's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DefaultRuntimeContextDevice
        {
            get { return this._defaultRuntimeContextDevice; }
            set { this._defaultRuntimeContextDevice = value; }
        }

        // Check to see if DefaultRuntimeContextDevice property is set
        internal bool IsSetDefaultRuntimeContextDevice()
        {
            return this._defaultRuntimeContextDevice != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the application instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property ManifestOverridesPayload. 
        /// <para>
        /// Setting overrides for the application manifest.
        /// </para>
        /// </summary>
        public ManifestOverridesPayload ManifestOverridesPayload
        {
            get { return this._manifestOverridesPayload; }
            set { this._manifestOverridesPayload = value; }
        }

        // Check to see if ManifestOverridesPayload property is set
        internal bool IsSetManifestOverridesPayload()
        {
            return this._manifestOverridesPayload != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestPayload. 
        /// <para>
        /// The application's manifest document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManifestPayload ManifestPayload
        {
            get { return this._manifestPayload; }
            set { this._manifestPayload = value; }
        }

        // Check to see if ManifestPayload property is set
        internal bool IsSetManifestPayload()
        {
            return this._manifestPayload != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the application instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeRoleArn. 
        /// <para>
        /// The ARN of a runtime role for the application instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RuntimeRoleArn
        {
            get { return this._runtimeRoleArn; }
            set { this._runtimeRoleArn = value; }
        }

        // Check to see if RuntimeRoleArn property is set
        internal bool IsSetRuntimeRoleArn()
        {
            return this._runtimeRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the application instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}