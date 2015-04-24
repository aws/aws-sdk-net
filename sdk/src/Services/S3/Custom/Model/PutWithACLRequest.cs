/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for put operations that can also put an ACL.
    /// </summary>
    public abstract class PutWithACLRequest : AmazonWebServiceRequest
    {
        private List<S3Grant> _grants;

        /// <summary>
        /// Gets the access control lists (ACLs) for this request. 
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// </summary>
        public List<S3Grant> Grants
        {
            get
            {
                if (null == _grants)
                {
                    _grants = new List<S3Grant>();
                }
                return _grants;
            }
            set
            {
                _grants = value;
            }
        }


    }
}
