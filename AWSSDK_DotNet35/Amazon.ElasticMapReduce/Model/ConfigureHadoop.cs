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
using System.Globalization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Valid config files.
    /// </summary>
    public enum ConfigFile
    {
        Site,
        Default,
        Core,
        Hdfs,
        Mapred
    }

    public class ConfigureHadoop
    {
        List<string> args = new List<string>();
        readonly string bucket;

        internal ConfigureHadoop(string bucket)
        {
            this.bucket = bucket;
        }

        /// <summary>
        /// Specify an XML file in S3 to merge with Hadoop's default configuration.
        /// </summary>
        /// <param name="file">The config file to merge with.</param>
        /// <param name="xmlPath">The path in S3 of the XML file.</param>
        public void AddXml(ConfigFile file, string xmlPath)
        {
            string arg = "";

            switch (file)
            {
                case ConfigFile.Site: 
                    arg = "-S"; 
                    break;
                case ConfigFile.Default: 
                    arg = "-D"; 
                    break;
                case ConfigFile.Core: 
                    arg = "-C"; 
                    break;
                case ConfigFile.Hdfs: 
                    arg = "-H"; 
                    break;
                case ConfigFile.Mapred: 
                    arg = "-M";
                    break;
            }

            args.Add(arg);
            args.Add(xmlPath);
        }
   
        /// <summary>
        ///  Specify a key-value pair to merge with Hadoop's default configuration.
        /// </summary>
        /// <param name="file">The config file to merge with.</param>
        /// <param name="key">The config key.</param>
        /// <param name="value">The config value.</param>
        public void AddKeyValue(ConfigFile file, String key, String value)
        {
            String arg = "";

            switch (file)
            {
                case ConfigFile.Site: 
                    arg = "-s"; 
                    break;
                case ConfigFile.Default: 
                    arg = "-d"; break;
                case ConfigFile.Core: 
                    arg = "-c"; 
                    break;
                case ConfigFile.Hdfs: 
                    arg = "-h"; 
                    break;
                case ConfigFile.Mapred: 
                    arg = "-m"; 
                    break;
            }
        
            args.Add(arg);
            args.Add(key + "=" + value);
        }

        /// <summary>
        /// Returns an object which can be used in a RunJobflow call.
        /// </summary>
        /// <returns>an object which can be used in a RunJobflow call.</returns>
        public BootstrapActionConfig Build()
        {
            return new BootstrapActionConfig
            {
                Name = "Configure Hadoop",
                ScriptBootstrapAction = new ScriptBootstrapActionConfig
                {
                    Path = string.Format(CultureInfo.InvariantCulture, "s3://{0}/bootstrap-actions/configure-hadoop", bucket),
                    Args = args
                }
            };
        }
    }
}
