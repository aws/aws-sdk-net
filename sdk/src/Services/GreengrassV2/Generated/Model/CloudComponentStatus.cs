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
    /// Contains the status of a component version in the IoT Greengrass service.
    /// </summary>
    public partial class CloudComponentStatus
    {
        private CloudComponentState _componentState;
        private Dictionary<string, string> _errors = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _message;
        private VendorGuidance _vendorGuidance;
        private string _vendorGuidanceMessage;

        /// <summary>
        /// Gets and sets the property ComponentState. 
        /// <para>
        /// The state of the component version.
        /// </para>
        /// </summary>
        public CloudComponentState ComponentState
        {
            get { return this._componentState; }
            set { this._componentState = value; }
        }

        // Check to see if ComponentState property is set
        internal bool IsSetComponentState()
        {
            return this._componentState != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A dictionary of errors that communicate why the component version is in an error state.
        /// For example, if IoT Greengrass can't access an artifact for the component version,
        /// then <c>errors</c> contains the artifact's URI as a key, and the error message as
        /// the value for that key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that communicates details, such as errors, about the status of the component
        /// version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property VendorGuidance. 
        /// <para>
        /// The vendor guidance state for the component version. This state indicates whether
        /// the component version has any issues that you should consider before you deploy it.
        /// The vendor guidance state can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – This component version is available and recommended for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCONTINUED</c> – This component version has been discontinued by its publisher.
        /// You can deploy this component version, but we recommend that you use a different version
        /// of this component.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> – This component version has been deleted by its publisher, so you
        /// can't deploy it. If you have any existing deployments that specify this component
        /// version, those deployments will fail.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VendorGuidance VendorGuidance
        {
            get { return this._vendorGuidance; }
            set { this._vendorGuidance = value; }
        }

        // Check to see if VendorGuidance property is set
        internal bool IsSetVendorGuidance()
        {
            return this._vendorGuidance != null;
        }

        /// <summary>
        /// Gets and sets the property VendorGuidanceMessage. 
        /// <para>
        /// A message that communicates details about the vendor guidance state of the component
        /// version. This message communicates why a component version is discontinued or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string VendorGuidanceMessage
        {
            get { return this._vendorGuidanceMessage; }
            set { this._vendorGuidanceMessage = value; }
        }

        // Check to see if VendorGuidanceMessage property is set
        internal bool IsSetVendorGuidanceMessage()
        {
            return this._vendorGuidanceMessage != null;
        }

    }
}