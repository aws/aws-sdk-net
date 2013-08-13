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
    /// The action to take if your step is waiting for the instance group to start
    /// and it enters the Arrested state.
    /// <para>
    /// Fail - Fail the step.
    /// Wait - Continue waiting until the instance group is no longer arrested (requires
    ///        manual intervention).
    /// Continue - Proceed onto the next step.
    /// </para>
    /// </summary>
    public enum OnArrested { Fail, Wait, Continue }

    /// <summary>
    /// Action to take if there is a failure modifying your cluster composition.
    /// Fail - Fail the step.
    /// Continue - Proceed on to the next step.
    /// </summary>
    public enum OnFailure { Fail, Continue }

    /// <summary>
    /// This class provides some helper methods for creating a Resize Job Flow step
    /// as part of your job flow. The resize step can be used to automatically
    /// adjust the composition of your cluster while it is running. For example, if
    /// you have a large workflow with different compute requirements, you can use
    /// this step to automatically add a task instance group before your most compute
    /// intensive step.
    ///
    /// <code>
    ///    AWSCredentials credentials = new BasicAWSCredentials(accessKey, secretKey);
    ///    AmazonElasticMapReduce emr = new AmazonElasticMapReduceClient(credentials);
    ///
    ///    HadoopJarStepConfig config = new ResizeJobFlowStep()
    ///        .WithResizeAction(new ModifyInstanceGroup()
    ///            .WithInstanceGroup("core")
    ///            .WithInstanceCount(10))
    ///        .WithResizeAction(new AddInstanceGroup()
    ///            .WithInstanceGroup("task")
    ///            .WithInstanceCount(10)
    ///            .WithInstanceType("m1.small"))
    ///        .WithOnArrested(OnArrested.Continue)
    ///        .WithOnFailure(OnFailure.Continue)
    ///        .ToHadoopJarStepConfig();
    ///
    ///    StepConfig resizeJobFlow = new StepConfig
    ///    {
    ///        Name = "Resize job flow",
    ///        ActionOnFailure = "TERMINATE_JOB_FLOW",
    ///        HadoopJarStep = config
    ///    };
    ///
    ///    RunJobFlowRequest request = new RunJobFlowRequest
    ///    {
    ///        Name = "Resize job flow",
    ///        Steps = new List&lt;StepConfig&gt; { resizeJobFlow },
    ///        LogUri = "s3://log-bucket/",
    ///        Instances = new JobFlowInstancesConfig
    ///        {
    ///            Ec2KeyName = "keypair",
    ///            HadoopVersion = "0.20",
    ///            InstanceCount = 5,
    ///            KeepJobFlowAliveWhenNoSteps = true,
    ///            MasterInstanceType = "m1.small",
    ///            SlaveInstanceType = "m1.small"
    ///        }
    ///    };
    ///
    ///    RunJobFlowResult result = emr.RunJobFlow(request).RunJobFlowResult;
    /// </code>
    /// </summary>
    public class ResizeJobFlowStep
    {

        string bucket;
        List<string> args = new List<string>();
        bool wait = true;
        OnArrested? onArrested = null;
        OnFailure? onFailure = null;


        /// <summary>
        /// Creates a new ResizeJobFlowStep using the default Elastic Map Reduce
        /// bucket (us-east-1.elasticmapreduce) for the default (us-east-1) region.
        /// </summary>
        public ResizeJobFlowStep()
            : this("us-east-1.elasticmapreduce")
        {
        }

        /// <summary>
        /// Creates a new ResizeJobFlowStep using the specified Amazon S3 bucket to
        /// load resources.
        /// <para>
        /// The official bucket format is "&lt;region&gt;.elasticmapreduce", so if
        /// you're using the us-east-1 region, you should use the bucket
        /// "us-east-1.elasticmapreduce".
        /// </para>
        /// </summary>
        /// <param name="bucket">The Amazon S3 bucket from which to load resources.</param>
        public ResizeJobFlowStep(string bucket)
        {
            this.bucket = bucket;
        }

        /// <summary>
        /// Add a new action for this step to perform. These actions can be to modify
        /// or add instance groups. This step supports multiple actions, but requires
        /// at least one be specified.
        /// </summary>
        /// <param name="resizeAction">An instance of ResizeAction defining the change.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///         together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResizeJobFlowStep WithResizeAction(ResizeAction resizeAction)
        {
            this.args.AddRange(resizeAction.Args);
            return this;
        }

        /// <summary>
        /// Specifies whether the step should wait for the modification to complete
        /// or if it should just continue onto the next step once the modification
        /// request is received. Defaults to true.
        /// </summary>
        /// <param name="wait">Whether this step should wait for the modification to complete.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///         together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResizeJobFlowStep WithWait(bool wait)
        {
            this.wait = wait;
            return this;
        }

        /// <summary>
        /// What action this step should take if any of the instance group modifications result
        /// in the instance group entering Arrested state. This can happen when the bootstrap
        /// actions on the newly launched instances are continuously failing.
        /// </summary>
        /// <param name="onArrested">OnArrested enum specifying which action to take</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///         together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResizeJobFlowStep WithOnArrested(OnArrested onArrested)
        {
            this.onArrested = onArrested;
            return this;
        }

        /// <summary>
        /// What action this step should take if the modification fails. This can happen when
        /// you request to perform an invalid action, such as shrink a core instance group.
        /// </summary>
        /// <param name="onFailure">OnFailure enum specifying which action to take.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///         together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ResizeJobFlowStep WithOnFailure(OnFailure onFailure)
        {
            this.onFailure = onFailure;
            return this;
        }

        /// <summary>
        /// Creates the final HadoopJarStepConfig once you are done configuring the step. You can use
        /// this as you would any other HadoopJarStepConfig.
        /// </summary>
        /// <returns>HadoopJarStepConfig configured to perform the specified actions.</returns>
        public HadoopJarStepConfig ToHadoopJarStepConfig()
        {
            if (args.Count == 0)
            {
                throw new AmazonElasticMapReduceException("Cannot create a ResizeJobFlowStep with no resize actions.");
            }

            if (wait == false)
            {
                args.Add("--no-wait");
            }

            if (onArrested != null)
            {
                args.Add("--on-arrested");
                args.Add(onArrested.ToString());
            }

            if (onFailure != null)
            {
                args.Add("--on-failure");
                args.Add(onFailure.ToString());
            }

            return new HadoopJarStepConfig
            {
                Jar = "s3://" + bucket + "/libs/resize-job-flow/0.1/resize-job-flow.jar",
                Args = args
            };
        }
    }

    public interface ResizeAction
    {
        List<string> Args { get; }
    }


    /**
    * Class representing a change to an existing instance group.
    */
    public class ModifyInstanceGroup : ResizeAction
    {
        string instanceGroup;
        int? instanceCount;

        /// <summary>
        /// Set the identification for the instance group to modify. You can specify either
        /// core or task if there is only one instance group of that role. Otherwise you can
        /// specify the instance group ID (such as ig-ABABABABABAB).
        /// </summary>
        /// <param name="instanceGroup">Identifier for the instance group.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///         together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyInstanceGroup WithInstanceGroup(string instanceGroup)
        {
            this.instanceGroup = instanceGroup;
            return this;
        }

        /// <summary>
        /// Specify the new size of the instance group.
        /// </summary>
        /// <param name="instanceCount">Target size of the instance group.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///         together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyInstanceGroup WithInstanceCount(int instanceCount)
        {
            this.instanceCount = instanceCount;
            return this;
        }

        public List<string> Args
        {
            get
            {
                if (instanceGroup == null)
                {
                    throw new AmazonElasticMapReduceException("InstanceGroup must not be null.");
                }
                if (instanceCount == null)
                {
                    throw new AmazonElasticMapReduceException("InstanceCount must not be null.");
                }

                List<string> args = new List<string>();
                args.Add("--modify-instance-group");
                args.Add(instanceGroup);
                args.Add("--instance-count");
                args.Add(instanceCount.ToString());
                return args;
            }
        }
    }


    /// <summary>
    /// Class representing creating a new instance group.
    /// </summary>
    public class AddInstanceGroup : ResizeAction
    {
        string instanceGroup;
        int? instanceCount;
        string instanceType;

        /// <summary>
        /// Specify the role of the new instance group (core, task).
        /// </summary>
        /// <param name="instanceGroup">New instance group's role.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddInstanceGroup WithInstanceGroup(string instanceGroup)
        {
            this.instanceGroup = instanceGroup;
            return this;
        }

        /// <summary>
        /// Specify the count of the new instance group.
        /// </summary>
        /// <param name="instanceCount">Target instance group size.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddInstanceGroup WithInstanceCount(int instanceCount)
        {
            this.instanceCount = instanceCount;
            return this;
        }

        /// <summary>
        /// Specify the instance type to use for this instance group.
        /// </summary>
        /// <param name="instanceType">Instance type.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddInstanceGroup WithInstanceType(string instanceType)
        {
            this.instanceType = instanceType;
            return this;
        }

        public List<string> Args
        {
            get
            {
                if (instanceGroup == null)
                {
                    throw new AmazonElasticMapReduceException("InstanceGroup must not be null.");
                }
                if (instanceCount == null)
                {
                    throw new AmazonElasticMapReduceException("InstanceCount must not be null.");
                }
                if (instanceType == null)
                {
                    throw new AmazonElasticMapReduceException("InstanceType must not be null.");
                }

                List<string> args = new List<string>();
                args.Add("--add-instance-group");
                args.Add(instanceGroup);
                args.Add("--instance-count");
                args.Add(instanceCount.ToString());
                args.Add("--instance-type");
                args.Add(instanceType);
                return args;
            }
        }
    }
}
