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
    /// Container for the parameters to the DeleteCustomDBEngineVersion operation.
    /// Deletes a custom engine version. To run this command, make sure you meet the following
    /// prerequisites:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The CEV must not be the default for RDS Custom. If it is, change the default before
    /// running this command.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The CEV must not be associated with an RDS Custom DB instance, RDS Custom instance
    /// snapshot, or automated backup of your RDS Custom instance.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Typically, deletion takes a few minutes.
    /// </para>
    ///  <note> 
    /// <para>
    /// The MediaImport service that imports files from Amazon S3 to create CEVs isn't integrated
    /// with Amazon Web Services CloudTrail. If you turn on data logging for Amazon RDS in
    /// CloudTrail, calls to the <code>DeleteCustomDbEngineVersion</code> event aren't logged.
    /// However, you might see calls from the API gateway that accesses your Amazon S3 bucket.
    /// These calls originate from the MediaImport service for the <code>DeleteCustomDbEngineVersion</code>
    /// event.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.delete">Deleting
    /// a CEV</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteCustomDBEngineVersionRequest : AmazonRDSRequest
    {
        private string _engine;
        private string _engineVersion;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine. The only supported engine is <code>custom-oracle-ee</code>.
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
        /// The custom engine version (CEV) for your DB instance. This option is required for
        /// RDS Custom, but optional for Amazon RDS. The combination of <code>Engine</code> and
        /// <code>EngineVersion</code> is unique per customer per Amazon Web Services Region.
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

    }
}