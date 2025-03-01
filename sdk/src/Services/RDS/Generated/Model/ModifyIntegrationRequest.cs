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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIntegration operation.
    /// Modifies a zero-ETL integration with Amazon Redshift.
    /// </summary>
    public partial class ModifyIntegrationRequest : AmazonRDSRequest
    {
        private string _dataFilter;
        private string _description;
        private string _integrationIdentifier;
        private string _integrationName;

        /// <summary>
        /// Gets and sets the property DataFilter. 
        /// <para>
        /// A new data filter for the integration. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Zero_ETL_Filtering.html">Data
        /// filtering for Aurora zero-ETL integrations with Amazon Redshift</a> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/zero-etl.filtering.html">Data
        /// filtering for Amazon RDS zero-ETL integrations with Amazon Redshift</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25600)]
        public string DataFilter
        {
            get { return this._dataFilter; }
            set { this._dataFilter = value; }
        }

        // Check to see if DataFilter property is set
        internal bool IsSetDataFilter()
        {
            return this._dataFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationIdentifier. 
        /// <para>
        /// The unique identifier of the integration to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string IntegrationIdentifier
        {
            get { return this._integrationIdentifier; }
            set { this._integrationIdentifier = value; }
        }

        // Check to see if IntegrationIdentifier property is set
        internal bool IsSetIntegrationIdentifier()
        {
            return this._integrationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// A new name for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string IntegrationName
        {
            get { return this._integrationName; }
            set { this._integrationName = value; }
        }

        // Check to see if IntegrationName property is set
        internal bool IsSetIntegrationName()
        {
            return this._integrationName != null;
        }

    }
}