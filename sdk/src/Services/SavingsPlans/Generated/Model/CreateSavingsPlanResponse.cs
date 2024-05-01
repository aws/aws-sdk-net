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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
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
namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// This is the response object from the CreateSavingsPlan operation.
    /// </summary>
    public partial class CreateSavingsPlanResponse : AmazonWebServiceResponse
    {
        private string _savingsPlanId;

        /// <summary>
        /// Gets and sets the property SavingsPlanId. 
        /// <para>
        /// The ID of the Savings Plan.
        /// </para>
        /// </summary>
        public string SavingsPlanId
        {
            get { return this._savingsPlanId; }
            set { this._savingsPlanId = value; }
        }

        // Check to see if SavingsPlanId property is set
        internal bool IsSetSavingsPlanId()
        {
            return this._savingsPlanId != null;
        }

    }
}