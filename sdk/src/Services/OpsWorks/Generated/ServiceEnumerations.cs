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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.OpsWorks
{

    /// <summary>
    /// Constants used for properties of type AppAttributesKeys.
    /// </summary>
    public class AppAttributesKeys : ConstantClass
    {

        /// <summary>
        /// Constant AutoBundleOnDeploy for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys AutoBundleOnDeploy = new AppAttributesKeys("AutoBundleOnDeploy");
        /// <summary>
        /// Constant AwsFlowRubySettings for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys AwsFlowRubySettings = new AppAttributesKeys("AwsFlowRubySettings");
        /// <summary>
        /// Constant DocumentRoot for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys DocumentRoot = new AppAttributesKeys("DocumentRoot");
        /// <summary>
        /// Constant RailsEnv for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys RailsEnv = new AppAttributesKeys("RailsEnv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppAttributesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppAttributesKeys FindValue(string value)
        {
            return FindValue<AppAttributesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppAttributesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppType.
    /// </summary>
    public class AppType : ConstantClass
    {

        /// <summary>
        /// Constant AwsFlowRuby for AppType
        /// </summary>
        public static readonly AppType AwsFlowRuby = new AppType("aws-flow-ruby");
        /// <summary>
        /// Constant Java for AppType
        /// </summary>
        public static readonly AppType Java = new AppType("java");
        /// <summary>
        /// Constant Nodejs for AppType
        /// </summary>
        public static readonly AppType Nodejs = new AppType("nodejs");
        /// <summary>
        /// Constant Other for AppType
        /// </summary>
        public static readonly AppType Other = new AppType("other");
        /// <summary>
        /// Constant Php for AppType
        /// </summary>
        public static readonly AppType Php = new AppType("php");
        /// <summary>
        /// Constant Rails for AppType
        /// </summary>
        public static readonly AppType Rails = new AppType("rails");
        /// <summary>
        /// Constant Static for AppType
        /// </summary>
        public static readonly AppType Static = new AppType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppType FindValue(string value)
        {
            return FindValue<AppType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant I386 for Architecture
        /// </summary>
        public static readonly Architecture I386 = new Architecture("i386");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoScalingType.
    /// </summary>
    public class AutoScalingType : ConstantClass
    {

        /// <summary>
        /// Constant Load for AutoScalingType
        /// </summary>
        public static readonly AutoScalingType Load = new AutoScalingType("load");
        /// <summary>
        /// Constant Timer for AutoScalingType
        /// </summary>
        public static readonly AutoScalingType Timer = new AutoScalingType("timer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingType FindValue(string value)
        {
            return FindValue<AutoScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchLogsEncoding.
    /// </summary>
    public class CloudWatchLogsEncoding : ConstantClass
    {

        /// <summary>
        /// Constant Ascii for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Ascii = new CloudWatchLogsEncoding("ascii");
        /// <summary>
        /// Constant Big5 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Big5 = new CloudWatchLogsEncoding("big5");
        /// <summary>
        /// Constant Big5hkscs for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Big5hkscs = new CloudWatchLogsEncoding("big5hkscs");
        /// <summary>
        /// Constant Cp037 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp037 = new CloudWatchLogsEncoding("cp037");
        /// <summary>
        /// Constant Cp1006 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1006 = new CloudWatchLogsEncoding("cp1006");
        /// <summary>
        /// Constant Cp1026 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1026 = new CloudWatchLogsEncoding("cp1026");
        /// <summary>
        /// Constant Cp1140 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1140 = new CloudWatchLogsEncoding("cp1140");
        /// <summary>
        /// Constant Cp1250 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1250 = new CloudWatchLogsEncoding("cp1250");
        /// <summary>
        /// Constant Cp1251 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1251 = new CloudWatchLogsEncoding("cp1251");
        /// <summary>
        /// Constant Cp1252 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1252 = new CloudWatchLogsEncoding("cp1252");
        /// <summary>
        /// Constant Cp1253 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1253 = new CloudWatchLogsEncoding("cp1253");
        /// <summary>
        /// Constant Cp1254 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1254 = new CloudWatchLogsEncoding("cp1254");
        /// <summary>
        /// Constant Cp1255 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1255 = new CloudWatchLogsEncoding("cp1255");
        /// <summary>
        /// Constant Cp1256 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1256 = new CloudWatchLogsEncoding("cp1256");
        /// <summary>
        /// Constant Cp1257 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1257 = new CloudWatchLogsEncoding("cp1257");
        /// <summary>
        /// Constant Cp1258 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp1258 = new CloudWatchLogsEncoding("cp1258");
        /// <summary>
        /// Constant Cp424 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp424 = new CloudWatchLogsEncoding("cp424");
        /// <summary>
        /// Constant Cp437 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp437 = new CloudWatchLogsEncoding("cp437");
        /// <summary>
        /// Constant Cp500 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp500 = new CloudWatchLogsEncoding("cp500");
        /// <summary>
        /// Constant Cp720 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp720 = new CloudWatchLogsEncoding("cp720");
        /// <summary>
        /// Constant Cp737 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp737 = new CloudWatchLogsEncoding("cp737");
        /// <summary>
        /// Constant Cp775 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp775 = new CloudWatchLogsEncoding("cp775");
        /// <summary>
        /// Constant Cp850 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp850 = new CloudWatchLogsEncoding("cp850");
        /// <summary>
        /// Constant Cp852 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp852 = new CloudWatchLogsEncoding("cp852");
        /// <summary>
        /// Constant Cp855 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp855 = new CloudWatchLogsEncoding("cp855");
        /// <summary>
        /// Constant Cp856 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp856 = new CloudWatchLogsEncoding("cp856");
        /// <summary>
        /// Constant Cp857 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp857 = new CloudWatchLogsEncoding("cp857");
        /// <summary>
        /// Constant Cp858 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp858 = new CloudWatchLogsEncoding("cp858");
        /// <summary>
        /// Constant Cp860 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp860 = new CloudWatchLogsEncoding("cp860");
        /// <summary>
        /// Constant Cp861 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp861 = new CloudWatchLogsEncoding("cp861");
        /// <summary>
        /// Constant Cp862 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp862 = new CloudWatchLogsEncoding("cp862");
        /// <summary>
        /// Constant Cp863 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp863 = new CloudWatchLogsEncoding("cp863");
        /// <summary>
        /// Constant Cp864 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp864 = new CloudWatchLogsEncoding("cp864");
        /// <summary>
        /// Constant Cp865 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp865 = new CloudWatchLogsEncoding("cp865");
        /// <summary>
        /// Constant Cp866 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp866 = new CloudWatchLogsEncoding("cp866");
        /// <summary>
        /// Constant Cp869 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp869 = new CloudWatchLogsEncoding("cp869");
        /// <summary>
        /// Constant Cp874 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp874 = new CloudWatchLogsEncoding("cp874");
        /// <summary>
        /// Constant Cp875 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp875 = new CloudWatchLogsEncoding("cp875");
        /// <summary>
        /// Constant Cp932 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp932 = new CloudWatchLogsEncoding("cp932");
        /// <summary>
        /// Constant Cp949 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp949 = new CloudWatchLogsEncoding("cp949");
        /// <summary>
        /// Constant Cp950 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Cp950 = new CloudWatchLogsEncoding("cp950");
        /// <summary>
        /// Constant Euc_jis_2004 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Euc_jis_2004 = new CloudWatchLogsEncoding("euc_jis_2004");
        /// <summary>
        /// Constant Euc_jisx0213 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Euc_jisx0213 = new CloudWatchLogsEncoding("euc_jisx0213");
        /// <summary>
        /// Constant Euc_jp for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Euc_jp = new CloudWatchLogsEncoding("euc_jp");
        /// <summary>
        /// Constant Euc_kr for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Euc_kr = new CloudWatchLogsEncoding("euc_kr");
        /// <summary>
        /// Constant Gb18030 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Gb18030 = new CloudWatchLogsEncoding("gb18030");
        /// <summary>
        /// Constant Gb2312 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Gb2312 = new CloudWatchLogsEncoding("gb2312");
        /// <summary>
        /// Constant Gbk for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Gbk = new CloudWatchLogsEncoding("gbk");
        /// <summary>
        /// Constant Hz for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Hz = new CloudWatchLogsEncoding("hz");
        /// <summary>
        /// Constant Iso2022_jp for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_jp = new CloudWatchLogsEncoding("iso2022_jp");
        /// <summary>
        /// Constant Iso2022_jp_1 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_jp_1 = new CloudWatchLogsEncoding("iso2022_jp_1");
        /// <summary>
        /// Constant Iso2022_jp_2 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_jp_2 = new CloudWatchLogsEncoding("iso2022_jp_2");
        /// <summary>
        /// Constant Iso2022_jp_2004 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_jp_2004 = new CloudWatchLogsEncoding("iso2022_jp_2004");
        /// <summary>
        /// Constant Iso2022_jp_3 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_jp_3 = new CloudWatchLogsEncoding("iso2022_jp_3");
        /// <summary>
        /// Constant Iso2022_jp_ext for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_jp_ext = new CloudWatchLogsEncoding("iso2022_jp_ext");
        /// <summary>
        /// Constant Iso2022_kr for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso2022_kr = new CloudWatchLogsEncoding("iso2022_kr");
        /// <summary>
        /// Constant Iso8859_10 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_10 = new CloudWatchLogsEncoding("iso8859_10");
        /// <summary>
        /// Constant Iso8859_13 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_13 = new CloudWatchLogsEncoding("iso8859_13");
        /// <summary>
        /// Constant Iso8859_14 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_14 = new CloudWatchLogsEncoding("iso8859_14");
        /// <summary>
        /// Constant Iso8859_15 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_15 = new CloudWatchLogsEncoding("iso8859_15");
        /// <summary>
        /// Constant Iso8859_16 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_16 = new CloudWatchLogsEncoding("iso8859_16");
        /// <summary>
        /// Constant Iso8859_2 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_2 = new CloudWatchLogsEncoding("iso8859_2");
        /// <summary>
        /// Constant Iso8859_3 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_3 = new CloudWatchLogsEncoding("iso8859_3");
        /// <summary>
        /// Constant Iso8859_4 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_4 = new CloudWatchLogsEncoding("iso8859_4");
        /// <summary>
        /// Constant Iso8859_5 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_5 = new CloudWatchLogsEncoding("iso8859_5");
        /// <summary>
        /// Constant Iso8859_6 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_6 = new CloudWatchLogsEncoding("iso8859_6");
        /// <summary>
        /// Constant Iso8859_7 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_7 = new CloudWatchLogsEncoding("iso8859_7");
        /// <summary>
        /// Constant Iso8859_8 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_8 = new CloudWatchLogsEncoding("iso8859_8");
        /// <summary>
        /// Constant Iso8859_9 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Iso8859_9 = new CloudWatchLogsEncoding("iso8859_9");
        /// <summary>
        /// Constant Johab for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Johab = new CloudWatchLogsEncoding("johab");
        /// <summary>
        /// Constant Koi8_r for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Koi8_r = new CloudWatchLogsEncoding("koi8_r");
        /// <summary>
        /// Constant Koi8_u for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Koi8_u = new CloudWatchLogsEncoding("koi8_u");
        /// <summary>
        /// Constant Latin_1 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Latin_1 = new CloudWatchLogsEncoding("latin_1");
        /// <summary>
        /// Constant Mac_cyrillic for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Mac_cyrillic = new CloudWatchLogsEncoding("mac_cyrillic");
        /// <summary>
        /// Constant Mac_greek for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Mac_greek = new CloudWatchLogsEncoding("mac_greek");
        /// <summary>
        /// Constant Mac_iceland for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Mac_iceland = new CloudWatchLogsEncoding("mac_iceland");
        /// <summary>
        /// Constant Mac_latin2 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Mac_latin2 = new CloudWatchLogsEncoding("mac_latin2");
        /// <summary>
        /// Constant Mac_roman for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Mac_roman = new CloudWatchLogsEncoding("mac_roman");
        /// <summary>
        /// Constant Mac_turkish for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Mac_turkish = new CloudWatchLogsEncoding("mac_turkish");
        /// <summary>
        /// Constant Ptcp154 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Ptcp154 = new CloudWatchLogsEncoding("ptcp154");
        /// <summary>
        /// Constant Shift_jis for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Shift_jis = new CloudWatchLogsEncoding("shift_jis");
        /// <summary>
        /// Constant Shift_jis_2004 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Shift_jis_2004 = new CloudWatchLogsEncoding("shift_jis_2004");
        /// <summary>
        /// Constant Shift_jisx0213 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Shift_jisx0213 = new CloudWatchLogsEncoding("shift_jisx0213");
        /// <summary>
        /// Constant Utf_16 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_16 = new CloudWatchLogsEncoding("utf_16");
        /// <summary>
        /// Constant Utf_16_be for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_16_be = new CloudWatchLogsEncoding("utf_16_be");
        /// <summary>
        /// Constant Utf_16_le for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_16_le = new CloudWatchLogsEncoding("utf_16_le");
        /// <summary>
        /// Constant Utf_32 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_32 = new CloudWatchLogsEncoding("utf_32");
        /// <summary>
        /// Constant Utf_32_be for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_32_be = new CloudWatchLogsEncoding("utf_32_be");
        /// <summary>
        /// Constant Utf_32_le for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_32_le = new CloudWatchLogsEncoding("utf_32_le");
        /// <summary>
        /// Constant Utf_7 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_7 = new CloudWatchLogsEncoding("utf_7");
        /// <summary>
        /// Constant Utf_8 for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_8 = new CloudWatchLogsEncoding("utf_8");
        /// <summary>
        /// Constant Utf_8_sig for CloudWatchLogsEncoding
        /// </summary>
        public static readonly CloudWatchLogsEncoding Utf_8_sig = new CloudWatchLogsEncoding("utf_8_sig");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchLogsEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchLogsEncoding FindValue(string value)
        {
            return FindValue<CloudWatchLogsEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchLogsEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchLogsInitialPosition.
    /// </summary>
    public class CloudWatchLogsInitialPosition : ConstantClass
    {

        /// <summary>
        /// Constant End_of_file for CloudWatchLogsInitialPosition
        /// </summary>
        public static readonly CloudWatchLogsInitialPosition End_of_file = new CloudWatchLogsInitialPosition("end_of_file");
        /// <summary>
        /// Constant Start_of_file for CloudWatchLogsInitialPosition
        /// </summary>
        public static readonly CloudWatchLogsInitialPosition Start_of_file = new CloudWatchLogsInitialPosition("start_of_file");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchLogsInitialPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchLogsInitialPosition FindValue(string value)
        {
            return FindValue<CloudWatchLogsInitialPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchLogsInitialPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchLogsTimeZone.
    /// </summary>
    public class CloudWatchLogsTimeZone : ConstantClass
    {

        /// <summary>
        /// Constant LOCAL for CloudWatchLogsTimeZone
        /// </summary>
        public static readonly CloudWatchLogsTimeZone LOCAL = new CloudWatchLogsTimeZone("LOCAL");
        /// <summary>
        /// Constant UTC for CloudWatchLogsTimeZone
        /// </summary>
        public static readonly CloudWatchLogsTimeZone UTC = new CloudWatchLogsTimeZone("UTC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchLogsTimeZone(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchLogsTimeZone FindValue(string value)
        {
            return FindValue<CloudWatchLogsTimeZone>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchLogsTimeZone(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentCommandName.
    /// </summary>
    public class DeploymentCommandName : ConstantClass
    {

        /// <summary>
        /// Constant Configure for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Configure = new DeploymentCommandName("configure");
        /// <summary>
        /// Constant Deploy for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Deploy = new DeploymentCommandName("deploy");
        /// <summary>
        /// Constant Execute_recipes for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Execute_recipes = new DeploymentCommandName("execute_recipes");
        /// <summary>
        /// Constant Install_dependencies for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Install_dependencies = new DeploymentCommandName("install_dependencies");
        /// <summary>
        /// Constant Restart for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Restart = new DeploymentCommandName("restart");
        /// <summary>
        /// Constant Rollback for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Rollback = new DeploymentCommandName("rollback");
        /// <summary>
        /// Constant Setup for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Setup = new DeploymentCommandName("setup");
        /// <summary>
        /// Constant Start for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Start = new DeploymentCommandName("start");
        /// <summary>
        /// Constant Stop for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Stop = new DeploymentCommandName("stop");
        /// <summary>
        /// Constant Undeploy for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Undeploy = new DeploymentCommandName("undeploy");
        /// <summary>
        /// Constant Update_custom_cookbooks for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Update_custom_cookbooks = new DeploymentCommandName("update_custom_cookbooks");
        /// <summary>
        /// Constant Update_dependencies for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Update_dependencies = new DeploymentCommandName("update_dependencies");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentCommandName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentCommandName FindValue(string value)
        {
            return FindValue<DeploymentCommandName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentCommandName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayerAttributesKeys.
    /// </summary>
    public class LayerAttributesKeys : ConstantClass
    {

        /// <summary>
        /// Constant BundlerVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys BundlerVersion = new LayerAttributesKeys("BundlerVersion");
        /// <summary>
        /// Constant EcsClusterArn for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys EcsClusterArn = new LayerAttributesKeys("EcsClusterArn");
        /// <summary>
        /// Constant EnableHaproxyStats for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys EnableHaproxyStats = new LayerAttributesKeys("EnableHaproxyStats");
        /// <summary>
        /// Constant GangliaPassword for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys GangliaPassword = new LayerAttributesKeys("GangliaPassword");
        /// <summary>
        /// Constant GangliaUrl for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys GangliaUrl = new LayerAttributesKeys("GangliaUrl");
        /// <summary>
        /// Constant GangliaUser for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys GangliaUser = new LayerAttributesKeys("GangliaUser");
        /// <summary>
        /// Constant HaproxyHealthCheckMethod for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyHealthCheckMethod = new LayerAttributesKeys("HaproxyHealthCheckMethod");
        /// <summary>
        /// Constant HaproxyHealthCheckUrl for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyHealthCheckUrl = new LayerAttributesKeys("HaproxyHealthCheckUrl");
        /// <summary>
        /// Constant HaproxyStatsPassword for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyStatsPassword = new LayerAttributesKeys("HaproxyStatsPassword");
        /// <summary>
        /// Constant HaproxyStatsUrl for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyStatsUrl = new LayerAttributesKeys("HaproxyStatsUrl");
        /// <summary>
        /// Constant HaproxyStatsUser for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyStatsUser = new LayerAttributesKeys("HaproxyStatsUser");
        /// <summary>
        /// Constant JavaAppServer for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JavaAppServer = new LayerAttributesKeys("JavaAppServer");
        /// <summary>
        /// Constant JavaAppServerVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JavaAppServerVersion = new LayerAttributesKeys("JavaAppServerVersion");
        /// <summary>
        /// Constant Jvm for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys Jvm = new LayerAttributesKeys("Jvm");
        /// <summary>
        /// Constant JvmOptions for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JvmOptions = new LayerAttributesKeys("JvmOptions");
        /// <summary>
        /// Constant JvmVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JvmVersion = new LayerAttributesKeys("JvmVersion");
        /// <summary>
        /// Constant ManageBundler for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys ManageBundler = new LayerAttributesKeys("ManageBundler");
        /// <summary>
        /// Constant MemcachedMemory for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys MemcachedMemory = new LayerAttributesKeys("MemcachedMemory");
        /// <summary>
        /// Constant MysqlRootPassword for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys MysqlRootPassword = new LayerAttributesKeys("MysqlRootPassword");
        /// <summary>
        /// Constant MysqlRootPasswordUbiquitous for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys MysqlRootPasswordUbiquitous = new LayerAttributesKeys("MysqlRootPasswordUbiquitous");
        /// <summary>
        /// Constant NodejsVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys NodejsVersion = new LayerAttributesKeys("NodejsVersion");
        /// <summary>
        /// Constant PassengerVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys PassengerVersion = new LayerAttributesKeys("PassengerVersion");
        /// <summary>
        /// Constant RailsStack for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys RailsStack = new LayerAttributesKeys("RailsStack");
        /// <summary>
        /// Constant RubygemsVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys RubygemsVersion = new LayerAttributesKeys("RubygemsVersion");
        /// <summary>
        /// Constant RubyVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys RubyVersion = new LayerAttributesKeys("RubyVersion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayerAttributesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayerAttributesKeys FindValue(string value)
        {
            return FindValue<LayerAttributesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayerAttributesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayerType.
    /// </summary>
    public class LayerType : ConstantClass
    {

        /// <summary>
        /// Constant AwsFlowRuby for LayerType
        /// </summary>
        public static readonly LayerType AwsFlowRuby = new LayerType("aws-flow-ruby");
        /// <summary>
        /// Constant Custom for LayerType
        /// </summary>
        public static readonly LayerType Custom = new LayerType("custom");
        /// <summary>
        /// Constant DbMaster for LayerType
        /// </summary>
        public static readonly LayerType DbMaster = new LayerType("db-master");
        /// <summary>
        /// Constant EcsCluster for LayerType
        /// </summary>
        public static readonly LayerType EcsCluster = new LayerType("ecs-cluster");
        /// <summary>
        /// Constant JavaApp for LayerType
        /// </summary>
        public static readonly LayerType JavaApp = new LayerType("java-app");
        /// <summary>
        /// Constant Lb for LayerType
        /// </summary>
        public static readonly LayerType Lb = new LayerType("lb");
        /// <summary>
        /// Constant Memcached for LayerType
        /// </summary>
        public static readonly LayerType Memcached = new LayerType("memcached");
        /// <summary>
        /// Constant MonitoringMaster for LayerType
        /// </summary>
        public static readonly LayerType MonitoringMaster = new LayerType("monitoring-master");
        /// <summary>
        /// Constant NodejsApp for LayerType
        /// </summary>
        public static readonly LayerType NodejsApp = new LayerType("nodejs-app");
        /// <summary>
        /// Constant PhpApp for LayerType
        /// </summary>
        public static readonly LayerType PhpApp = new LayerType("php-app");
        /// <summary>
        /// Constant RailsApp for LayerType
        /// </summary>
        public static readonly LayerType RailsApp = new LayerType("rails-app");
        /// <summary>
        /// Constant Web for LayerType
        /// </summary>
        public static readonly LayerType Web = new LayerType("web");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayerType FindValue(string value)
        {
            return FindValue<LayerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RootDeviceType.
    /// </summary>
    public class RootDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant Ebs for RootDeviceType
        /// </summary>
        public static readonly RootDeviceType Ebs = new RootDeviceType("ebs");
        /// <summary>
        /// Constant InstanceStore for RootDeviceType
        /// </summary>
        public static readonly RootDeviceType InstanceStore = new RootDeviceType("instance-store");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RootDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RootDeviceType FindValue(string value)
        {
            return FindValue<RootDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RootDeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant Archive for SourceType
        /// </summary>
        public static readonly SourceType Archive = new SourceType("archive");
        /// <summary>
        /// Constant Git for SourceType
        /// </summary>
        public static readonly SourceType Git = new SourceType("git");
        /// <summary>
        /// Constant S3 for SourceType
        /// </summary>
        public static readonly SourceType S3 = new SourceType("s3");
        /// <summary>
        /// Constant Svn for SourceType
        /// </summary>
        public static readonly SourceType Svn = new SourceType("svn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackAttributesKeys.
    /// </summary>
    public class StackAttributesKeys : ConstantClass
    {

        /// <summary>
        /// Constant Color for StackAttributesKeys
        /// </summary>
        public static readonly StackAttributesKeys Color = new StackAttributesKeys("Color");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackAttributesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackAttributesKeys FindValue(string value)
        {
            return FindValue<StackAttributesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackAttributesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualizationType.
    /// </summary>
    public class VirtualizationType : ConstantClass
    {

        /// <summary>
        /// Constant Hvm for VirtualizationType
        /// </summary>
        public static readonly VirtualizationType Hvm = new VirtualizationType("hvm");
        /// <summary>
        /// Constant Paravirtual for VirtualizationType
        /// </summary>
        public static readonly VirtualizationType Paravirtual = new VirtualizationType("paravirtual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualizationType FindValue(string value)
        {
            return FindValue<VirtualizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp2 = new VolumeType("gp2");
        /// <summary>
        /// Constant Io1 for VolumeType
        /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
        /// <summary>
        /// Constant Standard for VolumeType
        /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }

}