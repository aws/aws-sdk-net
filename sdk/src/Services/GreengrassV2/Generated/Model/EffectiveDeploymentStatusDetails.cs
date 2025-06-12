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
    /// Contains all error-related information for the deployment record. The status details
    /// will be null if the deployment is in a success state.
    /// 
    ///  <note> 
    /// <para>
    /// Greengrass nucleus v2.8.0 or later is required to get an accurate <c>errorStack</c>
    /// and <c>errorTypes</c> response. This field will not be returned for earlier Greengrass
    /// nucleus versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EffectiveDeploymentStatusDetails
    {
        private List<string> _errorStack = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _errorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ErrorStack. 
        /// <para>
        /// Contains an ordered list of short error codes that range from the most generic error
        /// to the most specific one. The error codes describe the reason for failure whenever
        /// the <c>coreDeviceExecutionStatus</c> is in a failed state. The response will be an
        /// empty list if there is no error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ErrorStack
        {
            get { return this._errorStack; }
            set { this._errorStack = value; }
        }

        // Check to see if ErrorStack property is set
        internal bool IsSetErrorStack()
        {
            return this._errorStack != null && (this._errorStack.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorTypes. 
        /// <para>
        /// Contains tags which describe the error. You can use the error types to classify errors
        /// to assist with remediating the failure. The response will be an empty list if there
        /// is no error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ErrorTypes
        {
            get { return this._errorTypes; }
            set { this._errorTypes = value; }
        }

        // Check to see if ErrorTypes property is set
        internal bool IsSetErrorTypes()
        {
            return this._errorTypes != null && (this._errorTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}