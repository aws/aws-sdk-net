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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The receiver configuration for a protected query.
    /// </summary>
    public partial class ReceiverConfiguration
    {
        private AnalysisType _analysisType;
        private ConfigurationDetails _configurationDetails;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        ///  The type of analysis for the protected query. The results of the query can be analyzed
        /// directly (<c>DIRECT_ANALYSIS</c>) or used as input into additional analyses (<c>ADDITIONAL_ANALYSIS</c>),
        /// such as a query that is a seed for a lookalike ML model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisType AnalysisType
        {
            get { return this._analysisType; }
            set { this._analysisType = value; }
        }

        // Check to see if AnalysisType property is set
        internal bool IsSetAnalysisType()
        {
            return this._analysisType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationDetails. 
        /// <para>
        ///  The configuration details of the receiver configuration.
        /// </para>
        /// </summary>
        public ConfigurationDetails ConfigurationDetails
        {
            get { return this._configurationDetails; }
            set { this._configurationDetails = value; }
        }

        // Check to see if ConfigurationDetails property is set
        internal bool IsSetConfigurationDetails()
        {
            return this._configurationDetails != null;
        }

    }
}