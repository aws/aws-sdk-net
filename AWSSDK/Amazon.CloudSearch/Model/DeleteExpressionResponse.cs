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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Returns information about the  DeleteExpressionResult response and response metadata.
    /// </summary>
    public class DeleteExpressionResponse : AmazonWebServiceResponse
    {
        private DeleteExpressionResult deleteExpressionResult;

        /// <summary>
        /// Gets and sets the DeleteExpressionResult property.
        /// The result of a DeleteExpression request. Specifies the expression being deleted.
        /// </summary>
        public DeleteExpressionResult DeleteExpressionResult
        {
            get
            {
                if(this.deleteExpressionResult == null)
                {
                    this.deleteExpressionResult = new DeleteExpressionResult();
                }

                return this.deleteExpressionResult;
            }
            set { this.deleteExpressionResult = value; }
        }
    }
}
    
