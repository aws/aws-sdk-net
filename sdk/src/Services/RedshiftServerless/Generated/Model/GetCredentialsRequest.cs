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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the GetCredentials operation.
    /// Returns a database user name and temporary password with temporary authorization to
    /// log in to Amazon Redshift Serverless.
    /// 
    ///  
    /// <para>
    /// By default, the temporary credentials expire in 900 seconds. You can optionally specify
    /// a duration between 900 seconds (15 minutes) and 3600 seconds (60 minutes).
    /// </para>
    ///  <pre><code> &lt;p&gt;The Identity and Access Management (IAM) user or role that runs
    /// GetCredentials must have an IAM policy attached that allows access to all necessary
    /// actions and resources.&lt;/p&gt; &lt;p&gt;If the &lt;code&gt;DbName&lt;/code&gt; parameter
    /// is specified, the IAM policy must allow access to the resource dbname for the specified
    /// database name.&lt;/p&gt; </code></pre>
    /// </summary>
    public partial class GetCredentialsRequest : AmazonRedshiftServerlessRequest
    {
        private string _dbName;
        private int? _durationSeconds;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of the database to get temporary authorization to log on to.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 64 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only uppercase or lowercase letters, numbers, underscore, plus sign,
        /// period (dot), at symbol (@), or hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not contain a colon ( : ) or slash ( / ).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be a reserved word. A list of reserved words can be found in <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words </a> in the Amazon Redshift Database Developer Guide
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DbName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DbName property is set
        internal bool IsSetDbName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The number of seconds until the returned temporary password expires. The minimum is
        /// 900 seconds, and the maximum is 3600 seconds.
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup associated with the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}