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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateResourceShare operation.
    /// Associates the specified resource share with the specified principals and resources.
    /// </summary>
    public partial class AssociateResourceShareRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private List<string> _principals = new List<string>();
        private List<string> _resourceArns = new List<string>();
        private string _resourceShareArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The principals to associate with the resource share. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services account ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Resource Name (ARN) of an organization in Organizations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an organizational unit (OU) in Organizations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM role
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM user
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Not all resource types can be shared with IAM roles and IAM users. For more information,
        /// see <a href="https://docs.aws.amazon.com/ram/latest/userguide/permissions.html#permissions-rbp-supported-resource-types">Sharing
        /// with IAM roles and IAM users</a> in the <i>Resource Access Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the resources.
        /// </para>
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

    }
}