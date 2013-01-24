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
    /// Class that makes it easy to define Hadoop Streaming steps.
    /// <para>
    /// See also: <a href="http://hadoop.apache.org/common/docs/r0.20.2/streaming.html">Hadoop Streaming</a>
    /// </para>
    /// <code>
    /// AWSCredentials credentials = new BasicAWSCredentials(accessKey, secretKey);
    /// AmazonElasticMapReduce emr = new AmazonElasticMapReduceClient(credentials);
    ///
    /// HadoopJarStepConfig config = new StreamingStep()
    ///     .WithInputs("s3://elasticmapreduce/samples/wordcount/input")
    ///     .WithOutput("s3://my-bucket/output/")
    ///     .WithMapper("s3://elasticmapreduce/samples/wordcount/wordSplitter.py")
    ///     .WithReducer("aggregate")
    ///     .ToHadoopJarStepConfig();
    ///
    /// StepConfig wordCount = new StepConfig()
    ///     .WithName("Word Count")
    ///     .WithActionOnFailure("TERMINATE_JOB_FLOW")
    ///     .WithHadoopJarStep(config);
    ///
    /// RunJobFlowRequest request = new RunJobFlowRequest()
    ///     .WithName("Word Count")
    ///     .WithSteps(wordCount)
    ///     .WithLogUri("s3://log-bucket/")
    ///     .WithInstances(new JobFlowInstancesConfig()
    ///         .WithEc2KeyName("keypairt")
    ///         .WithHadoopVersion("0.20")
    ///         .WithInstanceCount(5)
    ///         .WithKeepJobFlowAliveWhenNoSteps(true)
    ///         .WithMasterInstanceType("m1.small")
    ///         .WithSlaveInstanceType("m1.small"));
    ///
    /// RunJobFlowResult result = emr.RunJobFlow(request).RunJobFlowResult;
    /// </code>
    /// </summary>
    public class StreamingStep
    {
        List<string> inputs = new List<string>();
        string output;
        string mapper;
        string reducer;
        Dictionary<string, string> hadoopConfig = new Dictionary<string, string>();

        /// <summary>
        /// Creates a new default StreamingStep.
        /// </summary>
        public StreamingStep() 
        {
        }
      
        /// <summary>
        /// Gets and sets list of step input paths.
        /// </summary>
        /// <value>The inputs.</value>
        public List<string> Inputs
        {
            get { return inputs; }
            set { this.inputs = value; }
        }

        /// <summary>
        /// Add more input paths to this step.
        /// </summary>
        /// <param name="inputs">inputs a list of inputs to this step.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        ///       together.</returns>
        public StreamingStep WithInputs(params string[] inputs) 
        {
            if (this.inputs == null)
            {
                this.inputs = new List<string>();
            }

            foreach (string input in inputs) 
            {
                this.inputs.Add(input);
            }
            return this;
        }


        /// <summary>
        /// Gets and sets the output path.
        /// </summary>
        public string Output
        {
            get { return this.output; }
            set { this.output = value; }
        }

        /// <summary>
        /// Set the output path for this step.
        /// </summary>
        /// <param name="output">The output path.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        public StreamingStep WithOutput(string output) 
        {
            this.output = output;
            return this;
        }


        /// <summary>
        /// Gets and sets the mapper.
        /// </summary>
        public string Mapper
        {
            get { return this.mapper; }
            set { this.mapper = value; }
        }

        /// <summary>
        /// Set the mapper.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        public StreamingStep WithMapper(string mapper) 
        {
            this.mapper = mapper;
            return this;
        }


        /// <summary>
        /// Gets and sets the reducer.
        /// </summary>
        public string Reducer
        {
            get { return reducer; }
            set { this.reducer = value; }
        }


        /// <summary>
        /// Set the reducer.
        /// </summary>
        /// <param name="reducer">The reducer.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        public StreamingStep WithReducer(string reducer)
        {
            this.reducer = reducer;
            return this;
        }


        /// <summary>
        /// Gets and sets the hadoopConfig.
        /// </summary>
        public Dictionary<string, string> HadoopConfig
        {
            get { return hadoopConfig; }
            set { this.hadoopConfig = value; }
        }



        /// <summary>
        /// Add a Hadoop config override (-D value)
        /// </summary>
        /// <param name="key">Hadoop configuration key.</param>
        /// <param name="value">Configuration value.</param>
        /// <returns>A reference to this updated object so that method calls can be chained
        /// together.</returns>
        public StreamingStep WithHadoopConfig(string key, string value) 
        {
            hadoopConfig[key] = value;
            return this;
        }


        /// <summary>
        /// Creates the final HadoopJarStepConfig once you are done configuring the step. You can use
        /// this as you would any other HadoopJarStepConfig.
        /// </summary>
        /// <returns>HadoopJarStepConfig representing this streaming step.</returns>
        public HadoopJarStepConfig ToHadoopJarStepConfig() {
            List<string> args = new List<string>();

            if (reducer == null) {
                hadoopConfig.Add("mapred.reduce.tasks", "0");
            }

            foreach (KeyValuePair<string, string> entry in hadoopConfig) 
            {
                args.Add("-D");
                args.Add(string.Format("{0} = {1}", entry.Key, entry.Value));
            }

            foreach (string input in inputs) {
                args.Add("-input");
                args.Add(input);
            }

            if (output != null) {
                args.Add("-output");
                args.Add(output);
            }

            if (mapper != null) {
                args.Add("-mapper");
                args.Add(mapper);
            }

            if (reducer != null) {
                args.Add("-reducer");
                args.Add(reducer);
            }

            return new HadoopJarStepConfig()
                .WithJar("/home/hadoop/contrib/streaming/hadoop-streaming.jar")
                .WithArgs(args.ToArray());
        }
    }
}
