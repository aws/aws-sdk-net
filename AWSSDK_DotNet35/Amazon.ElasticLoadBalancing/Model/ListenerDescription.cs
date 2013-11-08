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
        /// properties to initialize this object after creating it.
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

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this.policyNames.Count > 0;
        }
    }
}
