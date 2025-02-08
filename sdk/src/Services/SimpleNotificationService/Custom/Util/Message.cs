using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

using Amazon.Runtime;
using Amazon.Util;

using System.Text.Json;

using Amazon.Runtime.Internal.Util;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Amazon.Util.Internal;

namespace Amazon.SimpleNotificationService.Util
{
    /// <summary>
    /// This class reads in JSON formatted Amazon SNS messages into Message objects. The messages can also be verified using the IsMessageSignatureValid operation.
    /// </summary>
    public partial class Message
    {
        private const int MAX_RETRIES = 3;
        private const string SHA1_SIGNATURE_VERSION = "1";
        private const string SHA256_SIGNATURE_VERSION = "2";

        /// <summary>
        /// The value of the Type property for a subscription confirmation message
        /// </summary>
        public const string MESSAGE_TYPE_SUBSCRIPTION_CONFIRMATION = "SubscriptionConfirmation";

        /// <summary>
        /// The value of the Type property for a unsubscribe confirmation message
        /// </summary>
        public const string MESSAGE_TYPE_UNSUBSCRIPTION_CONFIRMATION = "UnsubscribeConfirmation";

        /// <summary>
        /// The value of the Type property for a notification message
        /// </summary>
        public const string MESSAGE_TYPE_NOTIFICATION = "Notification";

        private Message()
        {
        }

        /// <summary>
        /// Parses the JSON message from Amazon SNS into the Message object.
        /// </summary>
        /// <param name="messageText">The JSON text from an Amazon SNS message</param>
        /// <returns>The Message object with properties set from the JSON document</returns>
        public static Message ParseMessage(string messageText)
        {
            var message = new Message();
            JsonDocument jsonData;
            jsonData = JsonDocument.Parse(messageText);

            Func<string, string> extractField = ((fieldName) =>
                {
                    if (jsonData.RootElement.TryGetProperty(fieldName, out var value) && value.ValueKind == JsonValueKind.String)
                    {
                        return value.GetString();
                    }
                    var anyCaseKey = jsonData.RootElement.EnumerateObject().FirstOrDefault(x => string.Equals(x.Name, fieldName, StringComparison.OrdinalIgnoreCase));
                    // Check to see if the field can be found with a different case.
                    if (!string.IsNullOrEmpty(anyCaseKey.Value.ToString()) && anyCaseKey.Value.ValueKind == JsonValueKind.String)
                    {
                        return anyCaseKey.Value.GetString();
                    }

                    return null;
                });

            message.MessageId = extractField("MessageId");
            message.MessageText = extractField("Message");
            message.Signature = extractField("Signature");
            message.SignatureVersion = ValidateSignatureVersion(extractField("SignatureVersion"));
            message.SigningCertURL = ValidateCertUrl(extractField("SigningCertURL"));
            message.SubscribeURL = extractField("SubscribeURL");
            message.Subject = extractField("Subject");
            message.TimestampString = extractField("Timestamp");
            message.Token = extractField("Token");
            message.TopicArn = extractField("TopicArn");
            message.Type = extractField("Type");
            message.UnsubscribeURL = extractField("UnsubscribeURL");

            return message;
        }

        /// <summary>
        /// Gets a Universally Unique Identifier, unique for each message published. For a notification that Amazon SNS resends during a retry, the message ID of the original message is used.
        /// </summary>
        public string MessageId
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the MessageText value specified when the notification was published to the topic.
        /// </summary>
        public string MessageText
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the Base64-encoded "SHA1withRSA" or "SHA256withRSA" signature of the Message, MessageId, Subject (if present), Type, Timestamp, and TopicArn values.
        /// </summary>
        public string Signature
        {
            get;
            private set;
        }



        /// <summary>
        /// Gets the Version of the Amazon SNS signature used.
        /// </summary>
        public string SignatureVersion
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the URL to the certificate that was used to sign the message.
        /// </summary>
        public string SigningCertURL
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the Subject parameter specified when the notification was published to the topic. Note that this is an optional parameter. 
        /// If no Subject was specified, then this name/value pair does not appear in this JSON document.
        /// </summary>
        public string Subject
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the URL that you must visit in order to re-confirm the subscription. Alternatively, you can instead use the Token with the ConfirmSubscription action to re-confirm the subscription.
        /// </summary>
        public string SubscribeURL
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the time (GMT) when the notification was published.
        /// </summary>
        public DateTime Timestamp
        {
            get
            {
                if (string.IsNullOrEmpty(this.TimestampString))
                    return DateTime.MinValue;

                return DateTime.ParseExact(this.TimestampString, AWSSDKUtils.ISO8601DateFormat, System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            }
        }

        private string TimestampString
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value you can use with the ConfirmSubscription action to re-confirm the subscription. Alternatively, you can simply visit the SubscribeURL.
        /// </summary>
        public string Token
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the Amazon Resource Name (ARN) for the topic.
        /// </summary>
        public string TopicArn
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the type of message. Possible values are Notification, SubscriptionConfirmation, and UnsubscribeConfirmation.
        /// </summary>
        public string Type
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns true if the message type is a subscription confirmation.
        /// </summary>
        /// <returns>True if the message type is a subscription confirmation.</returns>
        public bool IsSubscriptionType
        {
            get { return this.Type == Message.MESSAGE_TYPE_SUBSCRIPTION_CONFIRMATION; }
        }

        /// <summary>
        /// Returns true if the message type is a unsubscribe confirmation.
        /// </summary>
        /// <returns>True if the message type is a unsubscribe confirmation.</returns>        
        public bool IsUnsubscriptionType
        {
            get { return this.Type == Message.MESSAGE_TYPE_UNSUBSCRIPTION_CONFIRMATION; }
        }

        /// <summary>
        /// Returns true if the message type is a notification message.
        /// </summary>
        /// <returns>True if the message type is a notification message.</returns>        
        public bool IsNotificationType
        {
            get { return this.Type == Message.MESSAGE_TYPE_NOTIFICATION;}
        }

        /// <summary>
        /// Gets a URL that you can use to unsubscribe the endpoint from this topic. If you visit this URL, Amazon SNS unsubscribes the endpoint and stops sending notifications to this endpoint.
        /// </summary>
        public string UnsubscribeURL
        {
            get;
            private set;
        }

        private const string CertUrlRegexPattern = @"^sns\.[a-zA-Z0-9\-]{3,}\.amazonaws\.com(\.cn)?$";

#if NET8_0_OR_GREATER
        [GeneratedRegex(CertUrlRegexPattern)]
        private static partial Regex CertUrlRegex();
#else
        private static Regex CertUrlRegex() => _certUrlRegex;
        private static readonly Regex _certUrlRegex = new Regex(CertUrlRegexPattern);
#endif

        /// <summary>
        /// Verifies that the signing certificate url is from a recognizable source. 
        /// Returns the cert url if it cen be verified, otherwise throws an exception.
        /// </summary>
        /// <param name="certUrl"></param>
        /// <returns></returns>
        private static string ValidateCertUrl(string certUrl)
        {
            var uri = new Uri(certUrl);
            if (uri.Scheme == "https" && certUrl.EndsWith(".pem", StringComparison.Ordinal))
            {
                if (CertUrlRegex().IsMatch(uri.Host))
                    return certUrl;
            }

            throw new AmazonClientException("Signing certificate url is not from a recognised source.");
        }

        /// <summary>
        /// Verifies the SignatureVersion is either 1 for SHA1 or 2 for SHA256
        /// Returns true if is a valid value, otherwise throws an exception
        /// </summary>
        /// <param name="signatureVersion">SignatureVersion in a SNS message</param>
        /// <returns>Returns the SignatureVersion if it's a valid value, otherwise throws an exception</returns>
        private static string ValidateSignatureVersion(string signatureVersion)
        {
            if (signatureVersion == null)
            {
                throw new AmazonClientException("SignatureVersion is missing");
            }

            if (!signatureVersion.Equals(SHA1_SIGNATURE_VERSION) && !signatureVersion.Equals(SHA256_SIGNATURE_VERSION))
            {
                throw new AmazonClientException("SignatureVersion is not a valid value");
            }

            return signatureVersion;
        }

        private byte[] ParsePemContent(string content)
        {
            const string beginString = "-----BEGIN ";
            const string endString = "-----END ";

            var buffer = new StringBuilder();
            var lines = content.Split('\n');

            if (!lines[0].StartsWith(beginString))
            {
                throw new AmazonClientException("PEM file missing begin marker");
            }

            bool endMarkerFound = false;
            for (var i = 1; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(endString))
                {
                    endMarkerFound = true;
                    break;
                }

                if (lines[i].IndexOf(':') == -1)
                {
                    buffer.Append(lines[i].Trim());
                }
            }

            if (!endMarkerFound)
            {
                throw new AmazonClientException("PEM file missing end marker");
            }

            if (buffer.Length % 4 != 0)
            {
                throw new IOException("The base64 data appears in PEM file is truncated");
            }

            return Convert.FromBase64String(buffer.ToString());
        }

        #region Message Verification
        /// <summary>
        /// Verifies the authenticity of a message sent by Amazon SNS. This is done by computing a signature from the fields in the message and then comparing 
        /// the signature to the signature provided as part of the message.
        /// </summary>
        /// <returns>Returns true if the message is authentic.</returns>
        public bool IsMessageSignatureValid()
        {
            var bytesToSign = GetMessageBytesToSign();
            var certificate = GetX509Certificate();

#if BCL
            string cryptoConfig;
            if (this.SignatureVersion.Equals(SHA1_SIGNATURE_VERSION))
                cryptoConfig = CryptoConfig.MapNameToOID("SHA1");
            else
                cryptoConfig = CryptoConfig.MapNameToOID("SHA256");

            var rsa = certificate.PublicKey.Key as RSACryptoServiceProvider;
            return rsa.VerifyData(bytesToSign, cryptoConfig, Convert.FromBase64String(this.Signature));
#else
            HashAlgorithmName hashAlgorithmName;
            if (this.SignatureVersion.Equals(SHA1_SIGNATURE_VERSION))
                hashAlgorithmName = HashAlgorithmName.SHA1;
            else
                hashAlgorithmName = HashAlgorithmName.SHA256;

            var rsa = certificate.GetRSAPublicKey();
            return rsa.VerifyData(bytesToSign, Convert.FromBase64String(this.Signature), hashAlgorithmName, RSASignaturePadding.Pkcs1);
#endif
        }

        private byte[] GetMessageBytesToSign()
        {
            string stringToSign = null;

            if (this.IsNotificationType)
                stringToSign = BuildNotificationStringToSign();
            else if (this.IsSubscriptionType || this.IsUnsubscriptionType)
                stringToSign = BuildSubscriptionStringToSign();
            else
                throw new AmazonClientException("Unknown message type: " + this.Type);

            byte[] bytesToSign = UTF8Encoding.UTF8.GetBytes(stringToSign);
            return bytesToSign;
        }

        /// <summary>
        /// Build the string to sign for Notification messages.
        /// </summary>
        /// <returns>The string to sign</returns>
        private string BuildSubscriptionStringToSign()
        {
            StringBuilder stringToSign = new StringBuilder();

            stringToSign.Append("Message\n");
            stringToSign.Append(this.MessageText);
            stringToSign.Append("\n");

            stringToSign.Append("MessageId\n");
            stringToSign.Append(this.MessageId);
            stringToSign.Append("\n");

            stringToSign.Append("SubscribeURL\n");
            stringToSign.Append(this.SubscribeURL);
            stringToSign.Append("\n");

            stringToSign.Append("Timestamp\n");
            stringToSign.Append(this.TimestampString);
            stringToSign.Append("\n");

            stringToSign.Append("Token\n");
            stringToSign.Append(this.Token);
            stringToSign.Append("\n");

            stringToSign.Append("TopicArn\n");
            stringToSign.Append(this.TopicArn);
            stringToSign.Append("\n");

            stringToSign.Append("Type\n");
            stringToSign.Append(this.Type);
            stringToSign.Append("\n");

            return stringToSign.ToString();
        }

        /// <summary>
        /// Build the string to sign for SubscriptionConfirmation and UnsubscribeConfirmation messages.
        /// </summary>
        /// <returns>The string to sign</returns>
        private string BuildNotificationStringToSign()
        {
            StringBuilder stringToSign = new StringBuilder();

            stringToSign.Append("Message\n");
            stringToSign.Append(this.MessageText);
            stringToSign.Append("\n");

            stringToSign.Append("MessageId\n");
            stringToSign.Append(this.MessageId);
            stringToSign.Append("\n");

            if (this.Subject != null)
            {
                stringToSign.Append("Subject\n");
                stringToSign.Append(this.Subject);
                stringToSign.Append("\n");
            }

            stringToSign.Append("Timestamp\n");
            stringToSign.Append(this.TimestampString);
            stringToSign.Append("\n");


            stringToSign.Append("TopicArn\n");
            stringToSign.Append(this.TopicArn);
            stringToSign.Append("\n");

            stringToSign.Append("Type\n");
            stringToSign.Append(this.Type);
            stringToSign.Append("\n");

            return stringToSign.ToString();
        }

        static Dictionary<string, X509Certificate2> certificateCache = new Dictionary<string, X509Certificate2>();
        private X509Certificate2 GetX509Certificate()
        {
            lock (certificateCache)
            {
                if (certificateCache.ContainsKey(this.SigningCertURL))
                {
                    return certificateCache[this.SigningCertURL];
                }
                else
                {
                    for (int retries = 1; retries <= MAX_RETRIES; retries++)
                    {
                        try
                        {
#pragma warning disable SYSLIB0014 // Need to use HttpWebRequest while the SDK targets .NET Framework 3.5
                            HttpWebRequest request = HttpWebRequest.Create(this.SigningCertURL) as HttpWebRequest;
#pragma warning restore SYSLIB0014
#if BCL
                            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
#else
                            // It's illegal to await an async method within a lock statement block.
                            // So just get the response on this thread.
                            using (HttpWebResponse response = AsyncHelpers.RunSync(request.GetResponseAsync) as HttpWebResponse)
#endif
                            using (var reader = new StreamReader(response.GetResponseStream()))
                            {

                                var content = reader.ReadToEnd().Trim();

                                X509Certificate2 certificate = new X509Certificate2(ParsePemContent(content));
                                certificateCache[this.SigningCertURL] = certificate;
                                return certificate;
                            }
                        }
                        catch(Exception e)
                        {
                            if (retries == MAX_RETRIES)
                                throw new AmazonClientException(string.Format(CultureInfo.InvariantCulture,
                                    "Unable to download signing cert after {0} retries", MAX_RETRIES), e);
                            else
                                AWSSDKUtils.Sleep((int)(Math.Pow(4, retries) * 100));
                        }
                    }
                }

                throw new AmazonClientException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to download signing cert after {0} retries", MAX_RETRIES));
            }
        }
        #endregion

#if BCL
        #region Subscribe/Unsubscribe Actions
        /// <summary>
        /// Uses the SubscribeURL property to subscribe to the topic
        /// </summary>
        public void SubscribeToTopic()
        {
            MakeGetRequest(this.SubscribeURL, "subscribe");
        }

        /// <summary>
        /// Uses the UnsubscribeURL property to unsubscribe from the topic
        /// </summary>
        public void UnsubscribeFromTopic()
        {
            MakeGetRequest(this.UnsubscribeURL, "unsubscribe");
        }

        private static void MakeGetRequest(string url, string action)
        {
            for (int retries = 1; retries <= MAX_RETRIES; retries++)
            {
                try
                {
                    HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                    var response = request.GetResponse() as HttpWebResponse;
                    response.Close();
                    return;
                }
                catch (Exception e)
                {
                    if (retries == MAX_RETRIES)
                        throw new AmazonClientException(string.Format(CultureInfo.InvariantCulture,
                            "Unable to {0} after {1} retries", action, MAX_RETRIES), e);
                    else
                        AWSSDKUtils.Sleep((int)(Math.Pow(4, retries) * 100));
                }
            }
        }
        #endregion

#endif
    }
}
