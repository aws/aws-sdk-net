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
    /// The details of the Amazon Redshift storage as part of the configuration of an Amazon
    /// Redshift data source run.
    /// </summary>
    public partial class RedshiftStorage
    {
        private RedshiftClusterStorage _redshiftClusterSource;
        private RedshiftServerlessStorage _redshiftServerlessSource;

        /// <summary>
        /// Gets and sets the property RedshiftClusterSource. 
        /// <para>
        /// The details of the Amazon Redshift cluster source.
        /// </para>
        /// </summary>
        public RedshiftClusterStorage RedshiftClusterSource
        {
            get { return this._redshiftClusterSource; }
            set { this._redshiftClusterSource = value; }
        }

        // Check to see if RedshiftClusterSource property is set
        internal bool IsSetRedshiftClusterSource()
        {
            return this._redshiftClusterSource != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftServerlessSource. 
        /// <para>
        /// The details of the Amazon Redshift Serverless workgroup source.
        /// </para>
        /// </summary>
        public RedshiftServerlessStorage RedshiftServerlessSource
        {
            get { return this._redshiftServerlessSource; }
            set { this._redshiftServerlessSource = value; }
        }

        // Check to see if RedshiftServerlessSource property is set
        internal bool IsSetRedshiftServerlessSource()
        {
            return this._redshiftServerlessSource != null;
        }

    }
}