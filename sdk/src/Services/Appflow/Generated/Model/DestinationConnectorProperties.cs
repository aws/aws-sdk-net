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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This stores the information that is required to query a particular connector.
    /// </summary>
    public partial class DestinationConnectorProperties
    {
        private EventBridgeDestinationProperties _eventBridge;
        private RedshiftDestinationProperties _redshift;
        private S3DestinationProperties _s3;
        private SalesforceDestinationProperties _salesforce;
        private SnowflakeDestinationProperties _snowflake;
        private UpsolverDestinationProperties _upsolver;

        /// <summary>
        /// Gets and sets the property EventBridge. 
        /// <para>
        ///  The properties required to query Amazon EventBridge. 
        /// </para>
        /// </summary>
        public EventBridgeDestinationProperties EventBridge
        {
            get { return this._eventBridge; }
            set { this._eventBridge = value; }
        }

        // Check to see if EventBridge property is set
        internal bool IsSetEventBridge()
        {
            return this._eventBridge != null;
        }

        /// <summary>
        /// Gets and sets the property Redshift. 
        /// <para>
        ///  The properties required to query Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftDestinationProperties Redshift
        {
            get { return this._redshift; }
            set { this._redshift = value; }
        }

        // Check to see if Redshift property is set
        internal bool IsSetRedshift()
        {
            return this._redshift != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        ///  The properties required to query Amazon S3. 
        /// </para>
        /// </summary>
        public S3DestinationProperties S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The properties required to query Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceDestinationProperties Salesforce
        {
            get { return this._salesforce; }
            set { this._salesforce = value; }
        }

        // Check to see if Salesforce property is set
        internal bool IsSetSalesforce()
        {
            return this._salesforce != null;
        }

        /// <summary>
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  The properties required to query Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeDestinationProperties Snowflake
        {
            get { return this._snowflake; }
            set { this._snowflake = value; }
        }

        // Check to see if Snowflake property is set
        internal bool IsSetSnowflake()
        {
            return this._snowflake != null;
        }

        /// <summary>
        /// Gets and sets the property Upsolver. 
        /// <para>
        ///  The properties required to query Upsolver. 
        /// </para>
        /// </summary>
        public UpsolverDestinationProperties Upsolver
        {
            get { return this._upsolver; }
            set { this._upsolver = value; }
        }

        // Check to see if Upsolver property is set
        internal bool IsSetUpsolver()
        {
            return this._upsolver != null;
        }

    }
}