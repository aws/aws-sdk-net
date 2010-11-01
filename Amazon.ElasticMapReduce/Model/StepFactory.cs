﻿/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// This class provides helper methods for creating common Elastic MapReduce step
    /// types. To use StepFactory, you should construct it with the appropriate bucket
    /// for your region. The official bucket format is "&lt;region&gt;.elasticmapreduce", so
    /// us-east-1 would use the bucket "us-east-1.elasticmapreduce".
    /// </summary>
    /// <example>Create an interactive Hive job flow with debugging enabled:
    /// <code>
    ///  AmazonElasticMapReduce emr = AWSClientFactory.CreateAmazonElasticMapReduceClient(accessKey, secretKey);
    ///
    ///  StepFactory stepFactory = new StepFactory();
    ///
    ///  StepConfig enableDebugging = new StepConfig()
    ///     .WithName("Enable Debugging")
    ///     .WithActionOnFailure("TERMINATE_JOB_FLOW")
    ///     .WithHadoopJarStep(stepFactory.NewEnableDebuggingStep());
    ///
    ///  StepConfig installHive = new StepConfig()
    ///     .WithName("Install Hive")
    ///     .WithActionOnFailure("TERMINATE_JOB_FLOW")
    ///     .WithHadoopJarStep(stepFactory.NewInstallHiveStep());
    ///
    ///  RunJobFlowRequest request = new RunJobFlowRequest()
    ///     .WithName("Hive Interactive")
    ///     .WithSteps(enableDebugging, installHive)
    ///     .WithLogUri("s3://log-bucket/")
    ///     .WithInstances(new JobFlowInstancesConfig()
    ///         .WithEc2KeyName("keypair")
    ///         .WithHadoopVersion("0.20")
    ///         .WithInstanceCount(5)
    ///         .WithKeepJobFlowAliveWhenNoSteps(true)
    ///         .WithMasterInstanceType("m1.small")
    ///         .WithSlaveInstanceType("m1.small"));
    ///
    /// RunJobFlowResponse response = emr.RunJobFlow(request);
    /// </code>
    /// </example>
    public class StepFactory
    {
        private string bucket;

        private const string
            SWITCH_BASE_PATH       = "--base-path",
            SWITCH_INSTALL_HIVE    = "--install-hive",
            SWITCH_INSTALL_PIG     = "--install-pig",
            SWITCH_RUN_HIVE_SCRIPT = "--run-hive-script",
            SWITCH_RUN_PIG_SCRIPT  = "--run-pig-script",
            SWITCH_ARGS            = "--args",
            SWITCH_F               = "-f";

        private const string
            TOOL_HIVE = "hive",
            TOOL_PIG  = "pig";

        private const string 
            DEFAULT_BUCKET = "us-east-1.elasticmapreduce";

        public StepFactory(String bucket) 
        {
            this.bucket = bucket;
        }

        public StepFactory() 
            : this(DEFAULT_BUCKET)
        {
        }

        /// <summary>
        /// Runs a specified script on the master node of your cluster.
        /// </summary>
        /// <param name="script">The script to run</param>
        /// <param name="args">Arguments to be passed to the script.</param>
        /// <returns>HadoopJarStepConfig that can be passed to your job flow.</returns>
        public HadoopJarStepConfig NewScriptRunnerStep(string script, params string[] args)
        {
            string[] appendedArgs = new string[args.Length + 1];
            appendedArgs[0] = script;
            Array.Copy(args, 0, appendedArgs, 1, args.Length);

            return new HadoopJarStepConfig()
                .WithJar(String.Format("s3://{0}/libs/script-runner/script-runner.jar", bucket))
                .WithArgs(appendedArgs);
        }

        /// <summary>
        /// When run as the first step in your job flow, enables the Hadoop debugging UI
        /// in the AWS Management Console.
        /// </summary>
        /// <returns>HadoopJarStepConfig that can be passed to your job flow.</returns>
        public HadoopJarStepConfig NewEnableDebuggingStep() 
        {
            return NewScriptRunnerStep(String.Format("s3://{0}/libs/state-pusher/0.1/fetch", bucket));
        }

        private HadoopJarStepConfig newHivePigStep(string type, params string[] args) 
        {
            String[] argsArray = new String[args.Length + 2];
            argsArray[0] = SWITCH_BASE_PATH;
            argsArray[1] = String.Format("s3://{0}/libs/{1}/", bucket, type);
            Array.Copy(args, 0, argsArray, 2, args.Length);
            return NewScriptRunnerStep(String.Format("s3://{0}/libs/{1}/{1}-script", bucket, type), argsArray);
        }

        /// <summary>
        /// Step that installs Hive on your job flow.
        /// </summary>
        /// <returns>HadoopJarStepConfig that can be passed to your job flow.</returns>
        public HadoopJarStepConfig NewInstallHiveStep() 
        {
            return newHivePigStep(TOOL_HIVE, SWITCH_INSTALL_HIVE);
        }

        /// <summary>
        /// Step that runs a Hive script on your job flow.
        /// </summary>
        /// <param name="script">The script to run.</param>
        /// <param name="args">Arguments that get passed to the script.</param>
        /// <returns>HadoopJarStepConfig that can be passed to your job flow.</returns>
        public HadoopJarStepConfig NewRunHiveScriptStep(string script, params string[] args) 
        {
            string[] argsArray = new String[args.Length + 4];
            argsArray[0] = SWITCH_RUN_HIVE_SCRIPT;
            argsArray[1] = SWITCH_ARGS;
            argsArray[2] = SWITCH_F;
            argsArray[3] = script;
            Array.Copy(args, 0, argsArray, 4, args.Length);
            return newHivePigStep(TOOL_HIVE, argsArray);
        }

        /// <summary>
        /// Step that installs Pig on your job flow.
        /// </summary>
        /// <returns>HadoopJarStepConfig that can be passed to your job flow.</returns>
        public HadoopJarStepConfig NewInstallPigStep()
        {
            return newHivePigStep(TOOL_PIG, SWITCH_INSTALL_PIG);
        }

        /// <summary>
        /// Step that runs a Pig script on your job flow.
        /// </summary>
        /// <param name="script">The script to run.</param>
        /// <param name="args">Arguments that get passed to the script.</param>
        /// <returns>HadoopJarStepConfig that can be passed to your job flow.</returns>
        public HadoopJarStepConfig NewRunPigScriptStep(string script, params string[] args) 
        {
            string[] argsArray = new string[args.Length + 4];
            argsArray[0] = SWITCH_RUN_PIG_SCRIPT;
            argsArray[1] = SWITCH_ARGS;
            argsArray[2] = SWITCH_F;
            argsArray[3] = script;
            Array.Copy(args, 0, argsArray, 4, args.Length);
            return newHivePigStep(TOOL_PIG, argsArray);
        }
    }
}
