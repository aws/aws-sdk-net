/*
 * Author: David Iffland, Heavy Code LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 * http://aws.amazon.com/apache2.0
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Amazon.Util;

namespace AWSSDK.Amazon.TVMClient
{
    public class TVMClient
    {
        public string TvmUrl { get; set; }

     
        /// <summary>
        /// Called to initially register a device with the TVM. 
        /// </summary>
        /// <param name="deviceId">A 32 character device id.</param>
        /// <param name="tvmKey">A 32 character user defined key</param>
        /// <param name="callback">The callback method</param>
        public void RegisterDevice(string deviceId, string tvmKey, Action<bool, Exception> callback)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["uid"] = deviceId;
            parameters["key"] = tvmKey;

            string queryString = AWSSDKUtils.GetParametersAsString(parameters);

            var uri = new Uri(string.Format("{0}/registerdevice?{1}", TvmUrl, queryString));

            var hwr = WebRequest.Create(uri) as HttpWebRequest;
            if (hwr == null)
            {
                throw new NullReferenceException("Could not create HttpWebRequest");
            }
            
            hwr.Method = "GET";

            var tokenPackage = new TemporaryTokenPackage() {DeviceId = deviceId, Request = hwr};

            AsyncCallback responseHandler = (async) =>
                                                {
                                                    TemporaryTokenPackage temporaryTokenPackage =
                                                        (TemporaryTokenPackage) async.AsyncState;
                                                    HttpWebRequest request = temporaryTokenPackage.Request;

                                                    HttpWebResponse response = null;
                                                    try
                                                    {
                                                        response = (HttpWebResponse) request.EndGetResponse(async);
                                                        callback(true, null);

                                                    }
                                                    catch (WebException we)
                                                    {
                                                        if (((HttpWebResponse) we.Response).StatusDescription ==
                                                            "Conflict")
                                                        {
                                                            callback(true, null);
                                                        }
                                                        else
                                                        {
                                                            callback(false, we);
                                                        }

                                                    }
                                                };

            hwr.BeginGetResponse(responseHandler, tokenPackage);
        }

        /// <summary>
        /// Called to retrieve a set of temporary credentials from the TVM.
        /// </summary>
        /// <param name="deviceId">The same 32 character device ID used in RegisterDevice</param>
        /// <param name="tvmKey">The same 32 character TVM key used in RegisterDevice</param>
        /// <param name="callback">The callback method</param>
        public void GetTemporaryCredentials(string deviceId, string tvmKey, Action<AwsTemporaryCredentials, Exception> callback)
        {

            string timeStamp = AWSSDKUtils.GetFormattedTimestampISO8601(0);
            string signature = AWSSDKUtils.HMACSign(timeStamp, tvmKey, new HMACSHA256());

            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["uid"] = deviceId;
            parameters["timestamp"] = timeStamp;
            parameters["signature"] = signature;


            string queryString = AWSSDKUtils.GetParametersAsString(parameters);
            var uri = new Uri(string.Format("{0}/gettoken?{1}", TvmUrl, queryString));


            var hwr = WebRequest.Create(uri) as HttpWebRequest;
            if (hwr == null)
            {
                throw new NullReferenceException("Could not create HttpWebRequest");
            }

            AsyncCallback responseHandler = async =>
            {
                var request = (HttpWebRequest)async.AsyncState;

                HttpWebResponse response = null;
                try
                {
                    response = (HttpWebResponse)request.EndGetResponse(async);

                }
                catch (WebException we)
                {
                    callback(null, we);
                }

                if (IsGoodResponse(response))
                {
                    Stream stream = response.GetResponseStream();
                    if (stream != null)
                    {
                        var sr = new StreamReader(stream);

                        var responseText = sr.ReadToEnd();

                        sr.Close();

                        var dataToDecrypt = Convert.FromBase64String(responseText);

                        var plainText = Decrypt(dataToDecrypt, tvmKey);

                        var temporaryCredentials =
                            AwsTemporaryCredentialFactory.Create(plainText);

                        callback(temporaryCredentials, null);
                    }
                    else
                    {
                        callback(null, new WebException("Response stream was null"));
                    }

                    return;

                }
                else
                {
                    string responseText = "noresponse";

                    if (response != null)
                    {
                        responseText = response.StatusCode.ToString();
                    }

                    callback(null, new WebException("Bad web response, StatusCode=" + responseText));

                }
            };

            hwr.BeginGetResponse(responseHandler, hwr);
        }

      

        /// <summary>
        /// Override this to take a closer look at the response, for example to look at the status code.
        /// 
        /// Default implementation looks for HttpResponse.StatusCode == 200.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        protected virtual bool IsGoodResponse(HttpWebResponse response)
        {
            if (response == null)
                return false;

            return response.StatusCode == HttpStatusCode.OK;
        }

        public string Decrypt(byte[] dataToDecrypt, string secretKey)
        {
            var secretKeyToUse = DecodeHex(secretKey.ToCharArray());
            var cipher = CipherUtilities.GetCipher("AES/CBC/PKCS7Padding");

            cipher.Init(false, new KeyParameter(secretKeyToUse));


            int size = cipher.GetOutputSize(dataToDecrypt.Length);
            var results = new byte[size];

            int olen = cipher.ProcessBytes(dataToDecrypt, 0, dataToDecrypt.Length, results, 0);
            cipher.DoFinal(results, olen);

            var result = Encoding.UTF8.GetString(results, 0, results.Length);

            return result;
        }

        /// <summary>
        /// Used to decode a plain text key into a key that can be used to decrypt. The data being passed in is assumed to be a
        /// series of hex digits and this converts those 2-digit hex bytes into a single byte array.
        /// </summary>
        /// <remarks>This is adapated from the org.apache.commons.codec.binary.Hex java source code at http://kickjava.com/src/org/apache/commons/codec/binary/Hex.java.htm
        /// </remarks>
        /// <param name="data">An array of characters containing hex digits</param>
        /// <returns>A byte array containing the decoded hex data in binary format.</returns>
        public static byte[] DecodeHex(char[] data)
        {

            int len = data.Length;

            if ((len & 0x01) != 0)
            {
                throw new DataLengthException("Odd number of characters.");
            }

            var outresult = new byte[len >> 1];

            // two characters form the hex value.
            for (int i = 0, j = 0; j < len; i++)
            {
                var f = Convert.ToInt32(data[j++].ToString(), 16) << 4;
                f = f | Convert.ToInt32(data[j++].ToString(), 16);

                outresult[i] = (byte)(f & 0xFF);
            }

            return outresult;
        }

    }
}
