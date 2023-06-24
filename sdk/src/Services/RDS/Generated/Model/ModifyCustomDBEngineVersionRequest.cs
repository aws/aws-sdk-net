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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCustomDBEngineVersion operation.
    /// Modifies the status of a custom engine version (CEV). You can find CEVs to modify
    /// by calling <code>DescribeDBEngineVersions</code>.
    /// 
    ///  <note> 
    /// <para>
    /// The MediaImport service that imports files from Amazon S3 to create CEVs isn't integrated
    /// with Amazon Web Services CloudTrail. If you turn on data logging for Amazon RDS in
    /// CloudTrail, calls to the <code>ModifyCustomDbEngineVersion</code> event aren't logged.
    /// However, you might see calls from the API gateway that accesses your Amazon S3 bucket.
    /// These calls originate from the MediaImport service for the <code>ModifyCustomDbEngineVersion</code>
    /// event.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.modify">Modifying
    /// CEV status</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyCustomDBEngineVersionRequest : AmazonRDSRequest
    {
        private string _description;
        private string _engine;
        private string _engineVersion;
        private CustomEngineVersionStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of your CEV.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The DB engine. The only supported values are <code>custom-oracle-ee</code> and <code>custom-oracle-ee-cdb</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=35)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The custom engine version (CEV) that you want to modify. This option is required for
        /// RDS Custom for Oracle, but optional for Amazon RDS. The combination of <code>Engine</code>
        /// and <code>EngineVersion</code> is unique per customer per Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The availability status to be assigned to the CEV. Valid values are as follows:
        /// </para>
        ///  <dl> <dt>available</dt> <dd> 
        /// <para>
        /// You can use this CEV to create a new RDS Custom DB instance.
        /// </para>
        ///  </dd> <dt>inactive</dt> <dd> 
        /// <para>
        /// You can create a new RDS Custom instance by restoring a DB snapshot with this CEV.
        /// You can't patch or create new instances with this CEV.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// You can change any status to any status. A typical reason to change status is to prevent
        /// the accidental use of a CEV, or to make a deprecated CEV eligible for use again. For
        /// example, you might change the status of your CEV from <code>available</code> to <code>inactive</code>,
        /// and from <code>inactive</code> back to <code>available</code>. To change the availability
        /// status of the CEV, it must not currently be in use by an RDS Custom instance, snapshot,
        /// or automated backup.
        /// </para>
        /// </summary>
        public CustomEngineVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}