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
using System.Globalization;
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
    /// AWSCredentials credentials = new BasicAWSCredentials(accessKey, secretKey);
    /// IAmazonElasticMapReduce emr = new AmazonElasticMapReduceClient(credentials);
    ///
    /// var resize = new ResizeJobFlowStep
    /// {
    ///     OnArrested = OnArrested.Continue,
    ///     OnFailure = OnFailure.Continue
    /// };
    ///        
    /// resize.AddResizeAction(new AddInstanceGroup
    /// {
    ///     InstanceGroup = "core",
    ///     InstanceCount = 10
    /// });
    ///        
    /// resize.AddResizeAction(new AddInstanceGroup
    /// {
    ///     InstanceGroup = "task",
    ///     InstanceCount = 10,
    ///     WithInstanceType = "m1.small"
    /// });
    ///        
    /// HadoopJarStepConfig config = resize.ToHadoopJarStepConfig();
    ///
    /// StepConfig resizeJobFlow = new StepConfig {
    ///      Name = "Resize job flow",
    ///      ActionOnFailure = "TERMINATE_JOB_FLOW",
    ///      HadoopJarStep = config,
    /// };
    ///
    /// RunJobFlowRequest request = new RunJobFlowRequest {
    ///     Name = "Resize job flow",
    ///     Steps = new List&lt;StepConfig> { resizeJobFlow },
    ///     LogUri = "s3://log-bucket/",
    ///     Instances = new JobFlowInstancesConfig {
    ///         Ec2KeyName = "keypair",
    ///         HadoopVersion = "0.20",
    ///         InstanceCount = 5,
    ///         KeepJobFlowAliveWhenNoSteps = true,
    ///         MasterInstanceType = "m1.small",
    ///         SlaveInstanceType = "m1.small"
    ///     }
    /// };
    ///
    /// RunJobFlowResponse response = emr.RunJobFlow(request);
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
        public void AddResizeAction(ResizeAction resizeAction)
        {
            this.args.AddRange(resizeAction.Args);
        }

        /// <summary>
        /// Whether the step should wait for the modification to complete
        /// or if it should just continue onto the next step once the modification
        /// request is received. Defaults to true.
        /// </summary>
        public bool Wait
        {
            get { return  this.wait; }
            set { this.wait = value; }
        }

        /// <summary>
        /// What action this step should take if any of the instance group modifications result
        /// in the instance group entering Arrested state. This can happen when the bootstrap
        /// actions on the newly launched instances are continuously failing.
        /// </summary>
        public OnArrested? OnArrested
        {
            get { return  this.onArrested; }
            set { this.onArrested = value; }
        }

        /// <summary>
        /// What action this step should take if the modification fails. This can happen when
        /// you request to perform an invalid action, such as shrink a core instance group.
        /// </summary>
        public OnFailure? OnFailure
        {
            get { return  this.OnFailure; }
            set { this.onFailure = value; }
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
                Jar = string.Format(CultureInfo.InvariantCulture, "s3://{0}/libs/resize-job-flow/0.1/resize-job-flow.jar", bucket),
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
        /// The identification for the instance group to modify. You can specify either
        /// core or task if there is only one instance group of that role. Otherwise you can
        /// specify the instance group ID (such as ig-ABABABABABAB).
        /// </summary>
        public string InstanceGroup
        {
            get { return this.instanceGroup; }
            set { this.instanceGroup = value; }
        }
        /// <summary>
        /// Tthe new size of the instance group.
        /// </summary>
        public int? InstanceCount
        {
            get { return this.instanceCount; }
            set { this.instanceCount = value; }
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
        /// The role of the new instance group (core, task).
        /// </summary>
        public string InstanceGroup
        {
            get { return  this.instanceGroup; }
            set { this.instanceGroup = value; }
        }

        /// <summary>
        /// The count of the new instance group.
        /// </summary>
        public int? InstanceCount
        {
            get { return  this.instanceCount; }
            set { this.instanceCount = value; }
        }

        /// <summary>
        /// The instance type to use for this instance group.
        /// </summary>
        public string WithInstanceType
        {
            get { return  this.instanceType; }
            set { this.instanceType = value; }
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
