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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details for the self granting status for a data source.
    /// </summary>
    public partial class SelfGrantStatusOutput
    {
        private GlueSelfGrantStatusOutput _glueSelfGrantStatus;
        private RedshiftSelfGrantStatusOutput _redshiftSelfGrantStatus;

        /// <summary>
        /// Gets and sets the property GlueSelfGrantStatus. 
        /// <para>
        /// The details for the self granting status for a Glue data source.
        /// </para>
        /// </summary>
        public GlueSelfGrantStatusOutput GlueSelfGrantStatus
        {
            get { return this._glueSelfGrantStatus; }
            set { this._glueSelfGrantStatus = value; }
        }

        // Check to see if GlueSelfGrantStatus property is set
        internal bool IsSetGlueSelfGrantStatus()
        {
            return this._glueSelfGrantStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftSelfGrantStatus. 
        /// <para>
        /// The details for the self granting status for an Amazon Redshift data source.
        /// </para>
        /// </summary>
        public RedshiftSelfGrantStatusOutput RedshiftSelfGrantStatus
        {
            get { return this._redshiftSelfGrantStatus; }
            set { this._redshiftSelfGrantStatus = value; }
        }

        // Check to see if RedshiftSelfGrantStatus property is set
        internal bool IsSetRedshiftSelfGrantStatus()
        {
            return this._redshiftSelfGrantStatus != null;
        }

    }
}