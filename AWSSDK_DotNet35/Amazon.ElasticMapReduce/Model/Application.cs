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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>An application is any Amazon or third-party software that you can add to the cluster. This structure contains a list of strings that
    /// indicates the software to use with the cluster and accepts a user argument list. Amazon EMR accepts and forwards the argument list to the
    /// corresponding installation script as bootstrap action argument. For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-mapr.html" >Launch a Job Flow on the MapR Distribution for
    /// Hadoop</a> . Currently supported values are:</para>
    /// <ul>
    /// <li>"mapr-m3" - launch the job flow using MapR M3 Edition.</li>
    /// <li>"mapr-m5" - launch the job flow using MapR M5 Edition.</li>
    /// <li>"mapr" with the user arguments specifying "--edition,m3" or "--edition,m5" - launch the job flow using MapR M3 or M5 Edition,
    /// respectively.</li>
    /// 
    /// </ul>
    /// </summary>
    public class Application
    {
        
        private string name;
        private string version;
        private List<string> args = new List<string>();
        private Dictionary<string,string> additionalInfo = new Dictionary<string,string>();


        /// <summary>
        /// The name of the application.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The version of the application.
        ///  
        /// </summary>
        public string Version
        {
            get { return this.version; }
            set { this.version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this.version != null;
        }

        /// <summary>
        /// Arguments for Amazon EMR to pass to the application.
        ///  
        /// </summary>
        public List<string> Args
        {
            get { return this.args; }
            set { this.args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this.args.Count > 0;
        }

        /// <summary>
        /// This option is for advanced users only. This is meta information about third-party applications that third-party vendors use for testing
        /// purposes.
        ///  
        /// </summary>
        public Dictionary<string,string> AdditionalInfo
        {
            get { return this.additionalInfo; }
            set { this.additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this.additionalInfo != null;
        }
    }
}
