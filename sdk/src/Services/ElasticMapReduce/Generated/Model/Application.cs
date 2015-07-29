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

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An application is any Amazon or third-party software that you can add to the cluster.
    /// This structure contains a list of strings that indicates the software to use with
    /// the cluster and accepts a user argument list. Amazon EMR accepts and forwards the
    /// argument list to the corresponding installation script as bootstrap action argument.
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-mapr.html">Launch
    /// a Job Flow on the MapR Distribution for Hadoop</a>. Currently supported values are:
    /// 
    ///  <ul> <li>"mapr-m3" - launch the job flow using MapR M3 Edition.</li> <li>"mapr-m5"
    /// - launch the job flow using MapR M5 Edition.</li> <li>"mapr" with the user arguments
    /// specifying "--edition,m3" or "--edition,m5" - launch the job flow using MapR M3 or
    /// M5 Edition, respectively.</li> </ul> <note>
    /// <para>
    /// In Amazon EMR releases 4.0 and greater, the only accepted parameter is the application
    /// name. To pass arguments to applications, you supply a configuration for each application.
    /// </para>
    /// </note>
    /// </summary>
    public partial class Application
    {
        private Dictionary<string, string> _additionalInfo = new Dictionary<string, string>();
        private List<string> _args = new List<string>();
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// This option is for advanced users only. This is meta information about third-party
        /// applications that third-party vendors use for testing purposes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && this._additionalInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// Arguments for Amazon EMR to pass to the application.
        /// </para>
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the application.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}