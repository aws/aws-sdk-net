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
    /// This is the response object from the DescribeApplicationInstanceDetails operation.
    /// </summary>
    public partial class DescribeApplicationInstanceDetailsResponse : AmazonWebServiceResponse
    {
        private string _applicationInstanceId;
        private string _applicationInstanceIdToReplace;
        private DateTime? _createdTime;
        private string _defaultRuntimeContextDevice;
        private string _description;
        private ManifestOverridesPayload _manifestOverridesPayload;
        private ManifestPayload _manifestPayload;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApplicationInstanceId. 
        /// <para>
        /// The application instance's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ApplicationInstanceId
        {
            get { return this._applicationInstanceId; }
            set { this._applicationInstanceId = value; }
        }

        // Check to see if ApplicationInstanceId property is set
        internal bool IsSetApplicationInstanceId()
        {
            return this._applicationInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationInstanceIdToReplace. 
        /// <para>
        /// The ID of the application instance that this instance replaced.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the application instance was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultRuntimeContextDevice. 
        /// <para>
        /// The application instance's default runtime context device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The application instance's description.
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
        /// Parameter overrides for the configuration manifest.
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
        /// The application instance's configuration manifest.
        /// </para>
        /// </summary>
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
        /// The application instance's name.
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

    }
}