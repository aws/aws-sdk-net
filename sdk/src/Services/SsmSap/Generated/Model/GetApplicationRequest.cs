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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Container for the parameters to the GetApplication operation.
    /// Gets an application registered with AWS Systems Manager for SAP. It also returns the
    /// components of the application.
    /// </summary>
    public partial class GetApplicationRequest : AmazonSsmSapRequest
    {
        private string _applicationArn;
        private string _applicationId;
        private string _appRegistryArn;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application. 
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AppRegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application registry.
        /// </para>
        /// </summary>
        public string AppRegistryArn
        {
            get { return this._appRegistryArn; }
            set { this._appRegistryArn = value; }
        }

        // Check to see if AppRegistryArn property is set
        internal bool IsSetAppRegistryArn()
        {
            return this._appRegistryArn != null;
        }

    }
}