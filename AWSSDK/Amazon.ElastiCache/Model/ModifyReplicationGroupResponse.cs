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

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Returns information about the ModifyReplicationGroup response and response metadata.
    /// </summary>
    public class ModifyReplicationGroupResponse : AmazonWebServiceResponse
    {
        private ModifyReplicationGroupResult modifyReplicationGroupResult;

        /// 
        /// Gets and sets the ModifyReplicationGroupResult property.
        /// Contains the result of a successful invocation of the ModifyReplicationGroup
        /// action.
        /// 
        public ModifyReplicationGroupResult ModifyReplicationGroupResult
        {
            get
            {
                if(this.modifyReplicationGroupResult == null)
                {
                    this.modifyReplicationGroupResult = new ModifyReplicationGroupResult();
                }

                return this.modifyReplicationGroupResult;
            }
            set { this.modifyReplicationGroupResult = value; }
        }
    }
}
    
