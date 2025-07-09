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
    /// Container for the parameters to the UpdateCodeSecurityIntegration operation.
    /// Updates an existing code security integration.
    /// 
    ///  
    /// <para>
    /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
    /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
    /// operation to provide the <c>details</c> to complete the integration setup
    /// </para>
    /// </summary>
    public partial class UpdateCodeSecurityIntegrationRequest : AmazonInspector2Request
    {
        private UpdateIntegrationDetails _details;
        private string _integrationArn;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The updated integration details specific to the repository provider type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateIntegrationDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the code security integration to update.
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

    }
}