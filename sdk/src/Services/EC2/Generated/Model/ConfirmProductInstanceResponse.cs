/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of ConfirmProductInstance.
    /// </summary>
    public partial class ConfirmProductInstanceResponse : AmazonWebServiceResponse
    {
        private string _ownerId;
        private bool? _return;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The AWS account ID of the instance owner. This is only present if the product code
        /// is attached to the instance.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property Return. 
        /// <para>
        /// The return value of the request. Returns <code>true</code> if the specified product
        /// code is owned by the requester and associated with the specified instance.
        /// </para>
        /// </summary>
        public bool Return
        {
            get { return this._return.GetValueOrDefault(); }
            set { this._return = value; }
        }

        // Check to see if Return property is set
        internal bool IsSetReturn()
        {
            return this._return.HasValue; 
        }

    }
}