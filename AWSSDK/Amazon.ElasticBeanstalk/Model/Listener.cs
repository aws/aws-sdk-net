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
    /// <para>Describes the properties of a Listener for the LoadBalancer.</para>
    /// </summary>
    public class Listener  
    {
        
        private string protocol;
        private int? port;

        /// <summary>
        /// The protocol that is used by the Listener.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        /// <summary>
        /// Sets the Protocol property
        /// </summary>
        /// <param name="protocol">The value to set for the Protocol property </param>
        /// <returns>this instance</returns>
        public Listener WithProtocol(string protocol)
        {
            this.protocol = protocol;
            return this;
        }
            

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;       
        }

        /// <summary>
        /// The port that is used by the Listener.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        public Listener WithPort(int port)
        {
            this.port = port;
            return this;
        }
            

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;       
        }
    }
}
