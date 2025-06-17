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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the UpdateCodeSecurityIntegration operation.
    /// </summary>
    public partial class UpdateCodeSecurityIntegrationResponse : AmazonWebServiceResponse
    {
        private string _integrationArn;
        private IntegrationStatus _status;

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated code security integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated code security integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}