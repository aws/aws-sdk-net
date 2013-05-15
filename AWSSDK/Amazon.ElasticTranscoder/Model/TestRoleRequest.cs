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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the TestRole operation.
    /// <para> To test the IAM role that's used by Elastic Transcoder to create the pipeline, send a POST request to the
    /// <c>/2012-09-25/roleTests</c> resource. </para> <para>The <c>TestRole</c> action lets you determine whether the IAM role you are using has
    /// sufficient permissions to let Elastic Transcoder perform tasks associated with the transcoding process. The action attempts to assume the
    /// specified IAM role, checks read access to the input and output buckets, and tries to send a test notification to Amazon SNS topics that you
    /// specify.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.TestRole"/>
    public class TestRoleRequest : AmazonWebServiceRequest
    {
        private string role;
        private string inputBucket;
        private string outputBucket;
        private List<string> topics = new List<string>();

        /// <summary>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to test.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^arn:aws:iam::\w{12}:role/.+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        /// <summary>
        /// Sets the Role property
        /// </summary>
        /// <param name="role">The value to set for the Role property </param>
        /// <returns>this instance</returns>
        public TestRoleRequest WithRole(string role)
        {
            this.role = role;
            return this;
        }
            

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this.role != null;
        }

        /// <summary>
        /// The Amazon S3 bucket that contains media files to be transcoded. The action attempts to read from this bucket.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^(\w|\.|-){1,255}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InputBucket
        {
            get { return this.inputBucket; }
            set { this.inputBucket = value; }
        }

        /// <summary>
        /// Sets the InputBucket property
        /// </summary>
        /// <param name="inputBucket">The value to set for the InputBucket property </param>
        /// <returns>this instance</returns>
        public TestRoleRequest WithInputBucket(string inputBucket)
        {
            this.inputBucket = inputBucket;
            return this;
        }
            

        // Check to see if InputBucket property is set
        internal bool IsSetInputBucket()
        {
            return this.inputBucket != null;
        }

        /// <summary>
        /// The Amazon S3 bucket that Elastic Transcoder will write transcoded media files to. The action attempts to read from this bucket.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^(\w|\.|-){1,255}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string OutputBucket
        {
            get { return this.outputBucket; }
            set { this.outputBucket = value; }
        }

        /// <summary>
        /// Sets the OutputBucket property
        /// </summary>
        /// <param name="outputBucket">The value to set for the OutputBucket property </param>
        /// <returns>this instance</returns>
        public TestRoleRequest WithOutputBucket(string outputBucket)
        {
            this.outputBucket = outputBucket;
            return this;
        }
            

        // Check to see if OutputBucket property is set
        internal bool IsSetOutputBucket()
        {
            return this.outputBucket != null;
        }

        /// <summary>
        /// The ARNs of one or more Amazon Simple Notification Service (Amazon SNS) topics that you want the action to send a test notification to.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> Topics
        {
            get { return this.topics; }
            set { this.topics = value; }
        }
        /// <summary>
        /// Adds elements to the Topics collection
        /// </summary>
        /// <param name="topics">The values to add to the Topics collection </param>
        /// <returns>this instance</returns>
        public TestRoleRequest WithTopics(params string[] topics)
        {
            foreach (string element in topics)
            {
                this.topics.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Topics collection
        /// </summary>
        /// <param name="topics">The values to add to the Topics collection </param>
        /// <returns>this instance</returns>
        public TestRoleRequest WithTopics(IEnumerable<string> topics)
        {
            foreach (string element in topics)
            {
                this.topics.Add(element);
            }

            return this;
        }

        // Check to see if Topics property is set
        internal bool IsSetTopics()
        {
            return this.topics.Count > 0;
        }
    }
}
    
