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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>A list of available AWS Elastic Beanstalk solution stacks. </para>
    /// </summary>
    public class ListAvailableSolutionStacksResult  
    {
        
        private List<string> solutionStacks = new List<string>();
        private List<SolutionStackDescription> solutionStackDetails = new List<SolutionStackDescription>();

        /// <summary>
        /// A list of available solution stacks.
        ///  
        /// </summary>
        public List<string> SolutionStacks
        {
            get { return this.solutionStacks; }
            set { this.solutionStacks = value; }
        }
        /// <summary>
        /// Adds elements to the SolutionStacks collection
        /// </summary>
        /// <param name="solutionStacks">The values to add to the SolutionStacks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStacks(params string[] solutionStacks)
        {
            foreach (string element in solutionStacks)
            {
                this.solutionStacks.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SolutionStacks collection
        /// </summary>
        /// <param name="solutionStacks">The values to add to the SolutionStacks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStacks(IEnumerable<string> solutionStacks)
        {
            foreach (string element in solutionStacks)
            {
                this.solutionStacks.Add(element);
            }

            return this;
        }

        // Check to see if SolutionStacks property is set
        internal bool IsSetSolutionStacks()
        {
            return this.solutionStacks.Count > 0;       
        }

        /// <summary>
        /// A list of available solution stacks and their <a>SolutionStackDescription</a>.
        ///  
        /// </summary>
        public List<SolutionStackDescription> SolutionStackDetails
        {
            get { return this.solutionStackDetails; }
            set { this.solutionStackDetails = value; }
        }
        /// <summary>
        /// Adds elements to the SolutionStackDetails collection
        /// </summary>
        /// <param name="solutionStackDetails">The values to add to the SolutionStackDetails collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStackDetails(params SolutionStackDescription[] solutionStackDetails)
        {
            foreach (SolutionStackDescription element in solutionStackDetails)
            {
                this.solutionStackDetails.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SolutionStackDetails collection
        /// </summary>
        /// <param name="solutionStackDetails">The values to add to the SolutionStackDetails collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStackDetails(IEnumerable<SolutionStackDescription> solutionStackDetails)
        {
            foreach (SolutionStackDescription element in solutionStackDetails)
            {
                this.solutionStackDetails.Add(element);
            }

            return this;
        }

        // Check to see if SolutionStackDetails property is set
        internal bool IsSetSolutionStackDetails()
        {
            return this.solutionStackDetails.Count > 0;       
        }
    }
}
