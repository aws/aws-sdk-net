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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The ListenerDescription data type. </para>
    /// </summary>
    public class ListenerDescription  
    {
        
        private Listener listener;
        private List<string> policyNames = new List<string>();
        /// <summary>
        /// Default constructor for a new ListenerDescription object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public ListenerDescription() {}
    

        /// <summary>
        /// The Listener data type.
        ///  
        /// </summary>
        public Listener Listener
        {
            get { return this.listener; }
            set { this.listener = value; }
        }

        /// <summary>
        /// Sets the Listener property
        /// </summary>
        /// <param name="listener">The value to set for the Listener property </param>
        /// <returns>this instance</returns>
        public ListenerDescription WithListener(Listener listener)
        {
            this.listener = listener;
            return this;
        }
            

        // Check to see if Listener property is set
        internal bool IsSetListener()
        {
            return this.listener != null;       
        }

        /// <summary>
        /// A list of policies enabled for this listener. An empty list indicates that no policies are enabled.
        ///  
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this.policyNames; }
            set { this.policyNames = value; }
        }
        /// <summary>
        /// Adds elements to the PolicyNames collection
        /// </summary>
        /// <param name="policyNames">The values to add to the PolicyNames collection </param>
        /// <returns>this instance</returns>
        public ListenerDescription WithPolicyNames(params string[] policyNames)
        {
            foreach (string element in policyNames)
            {
                this.policyNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the PolicyNames collection
        /// </summary>
        /// <param name="policyNames">The values to add to the PolicyNames collection </param>
        /// <returns>this instance</returns>
        public ListenerDescription WithPolicyNames(IEnumerable<string> policyNames)
        {
            foreach (string element in policyNames)
            {
                this.policyNames.Add(element);
            }

            return this;
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this.policyNames.Count > 0;       
        }
    }
}
