/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A         list of available AWS Elastic Beanstalk         solution stacks.
    /// </summary>
    public partial class ListAvailableSolutionStacksResult
    {
        private List<SolutionStackDescription> _solutionStackDetails = new List<SolutionStackDescription>();
        private List<string> _solutionStacks = new List<string>();


        /// <summary>
        /// Gets and sets the property SolutionStackDetails. 
        /// <para>
        ///          A list of available solution stacks and their <a>SolutionStackDescription</a>.
        ///      
        /// </para>
        /// </summary>
        public List<SolutionStackDescription> SolutionStackDetails
        {
            get { return this._solutionStackDetails; }
            set { this._solutionStackDetails = value; }
        }

        /// <summary>
        /// Sets the SolutionStackDetails property
        /// </summary>
        /// <param name="solutionStackDetails">The values to add to the SolutionStackDetails collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStackDetails(params SolutionStackDescription[] solutionStackDetails)
        {
            foreach (var element in solutionStackDetails)
            {
                this._solutionStackDetails.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SolutionStackDetails property
        /// </summary>
        /// <param name="solutionStackDetails">The values to add to the SolutionStackDetails collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStackDetails(IEnumerable<SolutionStackDescription> solutionStackDetails)
        {
            foreach (var element in solutionStackDetails)
            {
                this._solutionStackDetails.Add(element);
            }
            return this;
        }
        // Check to see if SolutionStackDetails property is set
        internal bool IsSetSolutionStackDetails()
        {
            return this._solutionStackDetails != null && this._solutionStackDetails.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SolutionStacks. 
        /// <para>
        ///          A list of available solution stacks.        
        /// </para>
        /// </summary>
        public List<string> SolutionStacks
        {
            get { return this._solutionStacks; }
            set { this._solutionStacks = value; }
        }

        /// <summary>
        /// Sets the SolutionStacks property
        /// </summary>
        /// <param name="solutionStacks">The values to add to the SolutionStacks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStacks(params string[] solutionStacks)
        {
            foreach (var element in solutionStacks)
            {
                this._solutionStacks.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SolutionStacks property
        /// </summary>
        /// <param name="solutionStacks">The values to add to the SolutionStacks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAvailableSolutionStacksResult WithSolutionStacks(IEnumerable<string> solutionStacks)
        {
            foreach (var element in solutionStacks)
            {
                this._solutionStacks.Add(element);
            }
            return this;
        }
        // Check to see if SolutionStacks property is set
        internal bool IsSetSolutionStacks()
        {
            return this._solutionStacks != null && this._solutionStacks.Count > 0; 
        }

    }
}