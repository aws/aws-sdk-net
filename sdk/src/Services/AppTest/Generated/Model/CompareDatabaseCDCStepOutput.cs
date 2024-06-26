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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Compares the database CDC step output.
    /// </summary>
    public partial class CompareDatabaseCDCStepOutput
    {
        private string _comparisonOutputLocation;
        private ComparisonStatusEnum _comparisonStatus;

        /// <summary>
        /// Gets and sets the property ComparisonOutputLocation. 
        /// <para>
        /// The comparison output of the compare database CDC step output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComparisonOutputLocation
        {
            get { return this._comparisonOutputLocation; }
            set { this._comparisonOutputLocation = value; }
        }

        // Check to see if ComparisonOutputLocation property is set
        internal bool IsSetComparisonOutputLocation()
        {
            return this._comparisonOutputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonStatus. 
        /// <para>
        /// The comparison status of the compare database CDC step output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComparisonStatusEnum ComparisonStatus
        {
            get { return this._comparisonStatus; }
            set { this._comparisonStatus = value; }
        }

        // Check to see if ComparisonStatus property is set
        internal bool IsSetComparisonStatus()
        {
            return this._comparisonStatus != null;
        }

    }
}