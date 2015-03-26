/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Class that provides helper methods for constructing predefined bootstrap actions.
    /// </summary>
    /// <example>
    /// <code>
    /// IAmazonElasticMapReduce emr = TestUtil.EMRClient;
    ///
    /// BootstrapActions bootstrapActions = new BootstrapActions();
    ///
    /// var daemons = bootstrapActions.NewConfigureDaemons();
    /// daemons.AddHeapSize(Daemon.JobTracker, 2048);
    ///
    /// RunJobFlowRequest request = new RunJobFlowRequest
    /// {
    ///    Name = "Job Flow With Bootstrap Actions",
    ///    BootstrapActions = new List&lt;BootstrapActionConfig> 
    ///    {
    ///        bootstrapActions.NewRunIf("instance.isMaster=true", daemons.Build())
    ///    },
    ///    LogUri = "s3://log-bucket/",
    ///    Instances = new JobFlowInstancesConfig
    ///    {
    ///        Ec2KeyName = "keypair",
    ///        HadoopVersion = "0.20",
    ///        InstanceCount = 5,
    ///        KeepJobFlowAliveWhenNoSteps = true,
    ///        MasterInstanceType = "m1.small",
    ///        SlaveInstanceType = "m1.small"
    ///    }
    /// };
    ///
    /// RunJobFlowResponse response = emr.RunJobFlow(request);
    /// </code>
    /// </example> 
    public class BootstrapActions
    {
        readonly string bucket;

        /// <summary>
        /// Creates a new default BootstrapActions for us in us-east-1.
        /// </summary>
        public 
            BootstrapActions() : this("us-east-1.elasticmapreduce") {}

        /// <summary>
        /// Creates a new BootstrapActions.
        /// </summary>
        /// <param name="bucket">the bucket from which to download the bootstrap actions.</param>
        public BootstrapActions(string bucket) 
        {
            this.bucket = bucket;
        }

        /// <summary>
        /// Create a new run-if bootstrap action which lets you conditionally run bootstrap actions.
        /// </summary>
        /// <param name="condition">The condition to evaluate, if true the bootstrap action executes.</param>
        /// <param name="config">The bootstrap action to execute in case of successful evaluation.</param>
        /// <returns>A BootstrapActionConfig to be provided when running a job flow.</returns>
        public BootstrapActionConfig NewRunIf(string condition, BootstrapActionConfig config) 
        {
            List<string> args = config.ScriptBootstrapAction.Args;
            args.Add(condition);
            args.Add(config.ScriptBootstrapAction.Path);

            return new BootstrapActionConfig
            {
                Name = "Run If, " + config.Name,
                ScriptBootstrapAction = new ScriptBootstrapActionConfig
                {
                    Path = "s3://" + bucket + "/bootstrap-actions/run-if",
                    Args = args
                }
            };

        }

        /// <summary>
        /// Create a new bootstrap action which lets you configure Hadoop's XML files.
        /// </summary>
        public ConfigureHadoop NewConfigureHadoop() 
        {
            return new ConfigureHadoop(this.bucket);
        }

        /// <summary>
        /// Create a new bootstrap action which lets you configure Hadoop's daemons. The options
        /// are written to the hadoop-user-env.sh file.
        /// </summary>
        public ConfigureDaemons NewConfigureDaemons() 
        {
            return new ConfigureDaemons(this.bucket);
        }
    }
}

