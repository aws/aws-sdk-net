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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The configuration of the workgroup, which includes the location in Amazon Simple
    /// Storage Service (Amazon S3) where query results are stored, the encryption option,
    /// if any, used for query results, whether Amazon CloudWatch metrics are enabled for
    /// the workgroup, and the limit for the amount of bytes scanned (cutoff) per query, if
    /// it is specified.
    /// </summary>
    public partial class AwsAthenaWorkGroupConfigurationDetails
    {
        private AwsAthenaWorkGroupConfigurationResultConfigurationDetails _resultConfiguration;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        ///  The location in Amazon S3 where query and calculation results are stored and the
        /// encryption option, if any, used for query and calculation results. These are known
        /// as client-side settings. If workgroup settings override client-side settings, then
        /// the query uses the workgroup settings.
        /// </para>
        /// </summary>
        public AwsAthenaWorkGroupConfigurationResultConfigurationDetails ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

    }
}