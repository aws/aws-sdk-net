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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Comprehensive evaluation metrics for synthetic data that assess both the utility of
    /// the generated data for machine learning tasks and its privacy preservation characteristics.
    /// </summary>
    public partial class SyntheticDataEvaluationScores
    {
        private DataPrivacyScores _dataPrivacyScores;

        /// <summary>
        /// Gets and sets the property DataPrivacyScores. 
        /// <para>
        /// Privacy-specific evaluation scores that measure how well the synthetic data protects
        /// individual privacy, including assessments of potential privacy risks such as membership
        /// inference attacks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataPrivacyScores DataPrivacyScores
        {
            get { return this._dataPrivacyScores; }
            set { this._dataPrivacyScores = value; }
        }

        // Check to see if DataPrivacyScores property is set
        internal bool IsSetDataPrivacyScores()
        {
            return this._dataPrivacyScores != null;
        }

    }
}