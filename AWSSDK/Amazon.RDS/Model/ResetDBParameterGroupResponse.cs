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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Returns information about the  ResetDBParameterGroupResult response and response metadata.
    /// </summary>
    public class ResetDBParameterGroupResponse : AmazonWebServiceResponse
    {
        private ResetDBParameterGroupResult resetDBParameterGroupResult;

        /// <summary>
        /// Gets and sets the ResetDBParameterGroupResult property.
        /// Contains the result of a successful invocation of the ModifyDBParameterGroup or ResetDBParameterGroup action.
        /// </summary>
        public ResetDBParameterGroupResult ResetDBParameterGroupResult
        {
            get
            {
                if(this.resetDBParameterGroupResult == null)
                {
                    this.resetDBParameterGroupResult = new ResetDBParameterGroupResult();
                }

                return this.resetDBParameterGroupResult;
            }
            set { this.resetDBParameterGroupResult = value; }
        }
    }
}
    
