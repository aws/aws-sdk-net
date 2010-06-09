/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-25
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    ///<summary>
    ///Associates a Listener with the list of Policies enabled for it.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class ListenerDescription
    {
        private Listener listenerField;
        private List<string> policyNamesField;

        /// <summary>
        /// Gets and sets the Listener property.
        /// Specifies the configuration of the Listener for the Load Balacner.
        /// </summary>
        [XmlElementAttribute(ElementName = "Listener")]
        public Listener Listener
        {
            get { return this.listenerField; }
            set { this.listenerField = value; }
        }

        /// <summary>
        /// Sets the Listener property
        /// </summary>
        /// <param name="listener">Specifies the configuration of the Listener for the Load Balacner.</param>
        /// <returns>this instance</returns>
        public ListenerDescription WithListener(Listener listener)
        {
            this.listenerField = listener;
            return this;
        }

        /// <summary>
        /// Checks if Listener property is set
        /// </summary>
        /// <returns>true if Listener property is set</returns>
        public bool IsSetListener()
        {
            return this.listenerField != null;
        }

        /// <summary>
        /// Gets and sets the PolicyNames property.
        /// List of policies enabled for this listener. An empty list indicates that no policies are enabled.
        /// </summary>
        [XmlElementAttribute(ElementName = "PolicyNames")]
        public List<string> PolicyNames
        {
            get
            {
                if (this.policyNamesField == null)
                {
                    this.policyNamesField = new List<string>();
                }
                return this.policyNamesField;
            }
            set { this.policyNamesField = value; }
        }

        /// <summary>
        /// Sets the PolicyNames property
        /// </summary>
        /// <param name="list">List of policies enabled for this listener. An empty list indicates that no policies are enabled.</param>
        /// <returns>this instance</returns>
        public ListenerDescription WithPolicyNames(params string[] list)
        {
            foreach (string item in list)
            {
                PolicyNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if PolicyNames property is set
        /// </summary>
        /// <returns>true if PolicyNames property is set</returns>
        public bool IsSetPolicyNames()
        {
            return (PolicyNames.Count > 0);
        }

    }
}
