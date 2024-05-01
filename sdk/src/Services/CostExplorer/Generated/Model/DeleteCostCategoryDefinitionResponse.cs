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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the DeleteCostCategoryDefinition operation.
    /// </summary>
    public partial class DeleteCostCategoryDefinitionResponse : AmazonWebServiceResponse
    {
        private string _costCategoryArn;
        private string _effectiveEnd;

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The unique identifier for your Cost Category. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CostCategoryArn
        {
            get { return this._costCategoryArn; }
            set { this._costCategoryArn = value; }
        }

        // Check to see if CostCategoryArn property is set
        internal bool IsSetCostCategoryArn()
        {
            return this._costCategoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveEnd. 
        /// <para>
        /// The effective end date of the Cost Category as a result of deleting it. No costs after
        /// this date is categorized by the deleted Cost Category. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveEnd
        {
            get { return this._effectiveEnd; }
            set { this._effectiveEnd = value; }
        }

        // Check to see if EffectiveEnd property is set
        internal bool IsSetEffectiveEnd()
        {
            return this._effectiveEnd != null;
        }

    }
}