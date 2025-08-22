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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains input information for a canary run.
    /// </summary>
    public partial class CanaryRunConfigInput
    {
        private bool? _activeTracing;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _ephemeralStorage;
        private int? _memoryInMB;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property ActiveTracing. 
        /// <para>
        /// Specifies whether this canary is to use active X-Ray tracing when it runs. Active
        /// tracing enables this canary run to be displayed in the ServiceLens and X-Ray service
        /// maps even if the canary does not hit an endpoint that has X-Ray tracing enabled. Using
        /// X-Ray tracing incurs charges. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_tracing.html">
        /// Canaries and X-Ray tracing</a>.
        /// </para>
        ///  
        /// <para>
        /// You can enable active tracing only for canaries that use version <c>syn-nodejs-2.0</c>
        /// or later for their canary runtime.
        /// </para>
        /// </summary>
        public bool? ActiveTracing
        {
            get { return this._activeTracing; }
            set { this._activeTracing = value; }
        }

        // Check to see if ActiveTracing property is set
        internal bool IsSetActiveTracing()
        {
            return this._activeTracing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Specifies the keys and values to use for any environment variables used in the canary
        /// script. Use the following format:
        /// </para>
        ///  
        /// <para>
        /// { "key1" : "value1", "key2" : "value2", ...}
        /// </para>
        ///  
        /// <para>
        /// Keys must start with a letter and be at least two characters. The total size of your
        /// environment variables cannot exceed 4 KB. You can't specify any Lambda reserved environment
        /// variables as the keys for your environment variables. For more information about reserved
        /// keys, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html#configuration-envvars-runtime">
        /// Runtime environment variables</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Environment variable keys and values are encrypted at rest using Amazon Web Services
        /// owned KMS keys. However, the environment variables are not encrypted on the client
        /// side. Do not store sensitive information in them.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// Specifies the amount of ephemeral storage (in MB) to allocate for the canary run during
        /// execution. This temporary storage is used for storing canary run artifacts (which
        /// are uploaded to an Amazon S3 bucket at the end of the run), and any canary browser
        /// operations. This temporary storage is cleared after the run is completed. Default
        /// storage value is 1024 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=10240)]
        public int? EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryInMB. 
        /// <para>
        /// The maximum amount of memory available to the canary while it is running, in MB. This
        /// value must be a multiple of 64.
        /// </para>
        /// </summary>
        [AWSProperty(Min=960, Max=3008)]
        public int? MemoryInMB
        {
            get { return this._memoryInMB; }
            set { this._memoryInMB = value; }
        }

        // Check to see if MemoryInMB property is set
        internal bool IsSetMemoryInMB()
        {
            return this._memoryInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// How long the canary is allowed to run before it must stop. You can't set this time
        /// to be longer than the frequency of the runs of this canary.
        /// </para>
        ///  
        /// <para>
        /// If you omit this field, the frequency of the canary is used as this value, up to a
        /// maximum of 14 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=840)]
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}