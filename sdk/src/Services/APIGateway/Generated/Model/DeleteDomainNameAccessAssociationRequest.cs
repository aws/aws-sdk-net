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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDomainNameAccessAssociation operation.
    /// Deletes the DomainNameAccessAssociation resource.
    /// 
    ///  
    /// <para>
    /// Only the AWS account that created the DomainNameAccessAssociation resource can delete
    /// it. To stop an access association source in another AWS account from accessing your
    /// private custom domain name, use the RejectDomainNameAccessAssociation operation.
    /// </para>
    /// </summary>
    public partial class DeleteDomainNameAccessAssociationRequest : AmazonAPIGatewayRequest
    {
        private string _domainNameAccessAssociationArn;

        /// <summary>
        /// Gets and sets the property DomainNameAccessAssociationArn. 
        /// <para>
        ///  The ARN of the domain name access association resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainNameAccessAssociationArn
        {
            get { return this._domainNameAccessAssociationArn; }
            set { this._domainNameAccessAssociationArn = value; }
        }

        // Check to see if DomainNameAccessAssociationArn property is set
        internal bool IsSetDomainNameAccessAssociationArn()
        {
            return this._domainNameAccessAssociationArn != null;
        }

    }
}