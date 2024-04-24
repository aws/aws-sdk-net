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
    /// The measurement of how well you're using your existing Savings Plans.
    /// </summary>
    public partial class SavingsPlansUtilization
    {
        private string _totalCommitment;
        private string _unusedCommitment;
        private string _usedCommitment;
        private string _utilizationPercentage;

        /// <summary>
        /// Gets and sets the property TotalCommitment. 
        /// <para>
        /// The total amount of Savings Plans commitment that's been purchased in an account (or
        /// set of accounts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalCommitment
        {
            get { return this._totalCommitment; }
            set { this._totalCommitment = value; }
        }

        // Check to see if TotalCommitment property is set
        internal bool IsSetTotalCommitment()
        {
            return this._totalCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedCommitment. 
        /// <para>
        /// The amount of your Savings Plans commitment that wasn't consumed from Savings Plans
        /// eligible usage in a specific period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UnusedCommitment
        {
            get { return this._unusedCommitment; }
            set { this._unusedCommitment = value; }
        }

        // Check to see if UnusedCommitment property is set
        internal bool IsSetUnusedCommitment()
        {
            return this._unusedCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property UsedCommitment. 
        /// <para>
        /// The amount of your Savings Plans commitment that was consumed from Savings Plans eligible
        /// usage in a specific period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UsedCommitment
        {
            get { return this._usedCommitment; }
            set { this._usedCommitment = value; }
        }

        // Check to see if UsedCommitment property is set
        internal bool IsSetUsedCommitment()
        {
            return this._usedCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property UtilizationPercentage. 
        /// <para>
        /// The amount of <c>UsedCommitment</c> divided by the <c>TotalCommitment</c> for your
        /// Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UtilizationPercentage
        {
            get { return this._utilizationPercentage; }
            set { this._utilizationPercentage = value; }
        }

        // Check to see if UtilizationPercentage property is set
        internal bool IsSetUtilizationPercentage()
        {
            return this._utilizationPercentage != null;
        }

    }
}