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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCoipCidr operation.
    /// Deletes a range of customer-owned IP addresses.
    /// </summary>
    public partial class DeleteCoipCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private string _coipPoolId;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        ///  A customer-owned IP address range that you want to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property CoipPoolId. 
        /// <para>
        ///  The ID of the customer-owned address pool. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CoipPoolId
        {
            get { return this._coipPoolId; }
            set { this._coipPoolId = value; }
        }

        // Check to see if CoipPoolId property is set
        internal bool IsSetCoipPoolId()
        {
            return this._coipPoolId != null;
        }

    }
}