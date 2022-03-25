/*
 Navicat Premium Data Transfer

 Source Server         : 本机的mysql 3306
 Source Server Type    : MySQL
 Source Server Version : 80023
 Source Host           : localhost:3306
 Source Schema         : supermarket

 Target Server Type    : MySQL
 Target Server Version : 80023
 File Encoding         : 65001

 Date: 28/04/2021 20:41:05
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `EID` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工id',
  `EName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工姓名',
  `ESex` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工性别',
  `EAge` int(0) NOT NULL COMMENT '员工年龄',
  `EPID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工职位id',
  `ETel` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工电话',
  `EPasswd` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登陆密码',
  `EAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工地址',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 12 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '员工信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES (1, 'admin', 'Gaiokane', '男', 22, '1', '00000000000', 'qqq', '111');
INSERT INTO `employee` VALUES (2, 'q', 'qk', '男', 23, '2', '13776242820', 'q', 'zjg');
INSERT INTO `employee` VALUES (3, 'xtgly', '系统管理员', '男', 11, '1', '17681050813', 'xtgly', '1');
INSERT INTO `employee` VALUES (4, 'dz', '我是店长', '男', 12, '2', '22222222222', 'dz', '2');
INSERT INTO `employee` VALUES (5, 'rsb', '我是人事部', '男', 13, '3', '33333333333', 'rsb', '3');
INSERT INTO `employee` VALUES (6, 'xsb', '我是销售部', '女', 14, '4', '44444444444', 'xsb', '4');
INSERT INTO `employee` VALUES (7, 'kcglb', '我是库存管理部', '女', 15, '5', '55555555555', 'kcglb', '5');
INSERT INTO `employee` VALUES (8, 'syy1', '我是收银员1', '男', 16, '6', '66666666666', 'syy1', '6');
INSERT INTO `employee` VALUES (9, 'syy2', '我是收银员2', '女', 17, '6', '77777777777', 'syy2', '7');
INSERT INTO `employee` VALUES (10, 'syy3', '我是收银员3', '女', 18, '6', '88888888888', 'syy3', '8');
INSERT INTO `employee` VALUES (11, 'admin1', 'vvv', '男', 12, '6', '12345678900', 'admin1', '1');

-- ----------------------------
-- Table structure for employeeposition
-- ----------------------------
DROP TABLE IF EXISTS `employeeposition`;
CREATE TABLE `employeeposition`  (
  `EPID` int(0) NOT NULL AUTO_INCREMENT COMMENT '职位id',
  `EPName` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '职位名称',
  `EPCount` int(0) NULL DEFAULT NULL COMMENT '职位人数',
  PRIMARY KEY (`EPID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci COMMENT = '员工职位表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employeeposition
-- ----------------------------
INSERT INTO `employeeposition` VALUES (1, '系统管理员', 2);
INSERT INTO `employeeposition` VALUES (2, '店长', 2);
INSERT INTO `employeeposition` VALUES (3, '人事部', 1);
INSERT INTO `employeeposition` VALUES (4, '销售部', 1);
INSERT INTO `employeeposition` VALUES (5, '库存管理部', 1);
INSERT INTO `employeeposition` VALUES (6, '收银员', 3);

-- ----------------------------
-- Table structure for goods
-- ----------------------------
DROP TABLE IF EXISTS `goods`;
CREATE TABLE `goods`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `GID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品id',
  `GName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品名称',
  `GCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品分类id',
  `GPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品售价',
  `GBid` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品进价',
  `GAmount` int(0) NULL DEFAULT NULL COMMENT '商品库存',
  `GMinimumInventory` int(0) NULL DEFAULT NULL COMMENT '商品最小库存',
  `GUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品单位',
  `GShelfLife` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品有效期',
  `GProductionDate` datetime(0) NULL DEFAULT NULL COMMENT '商品生产日期',
  `GSupplier` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品供应商',
  `GNotes` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品说明/备注',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 40 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '商品信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of goods
-- ----------------------------
INSERT INTO `goods` VALUES (13, 'G205047324', '蒙牛纯牛奶', '1', 42.00, 33.00, 18, 10, '箱', '180天', '2018-04-03 00:00:00', '内蒙古蒙牛乳业（集团）股份有限公司', '');
INSERT INTO `goods` VALUES (14, 'G205233827', '伊利安慕希原味酸奶', '1', 6.50, 38.00, 6, 5, '箱', '6个月', '2018-04-11 00:00:00', '内蒙古伊利实业集团股份有限公司', '');
INSERT INTO `goods` VALUES (15, 'G205421245', '港荣奶香蒸蛋糕', '1', 38.20, 26.00, 9, 15, '箱', '35天', '2018-04-11 00:00:00', '港荣食品发展有限公司', '');
INSERT INTO `goods` VALUES (16, 'G205633524', '乐事薯片礼盒', '1', 16.90, 48.00, 17, 20, '箱', '9个月', '2018-04-11 00:00:00', '百事公司', '');
INSERT INTO `goods` VALUES (17, 'G205832023', '百事巴厘岛蓝色可乐', '1', 12.90, 8.00, 44, 30, '瓶', '12个月', '2018-04-11 00:00:00', '百事公司', '');
INSERT INTO `goods` VALUES (18, 'G205904834', '金龙鱼玉米油', '2', 39.90, 31.00, 9, 5, '桶', '18个月', '2018-04-07 00:00:00', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `goods` VALUES (19, 'G210114645', '鲁花5S一级花生油', '2', 119.90, 93.00, 7, 5, '桶', '18个月', '2018-04-11 00:00:00', '山东鲁花集团有限公司', '');
INSERT INTO `goods` VALUES (20, 'G210854825', '金龙鱼盘锦大米', '2', 16.90, 48.00, 20, 10, '袋', '18个月', '2018-04-11 00:00:00', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `goods` VALUES (21, 'G210927823', '清扬男士去屑洗发露', '3', 10.80, 44.00, 17, 5, '瓶', '36个月', '2018-04-11 00:00:00', '清扬技术中心', '');
INSERT INTO `goods` VALUES (22, 'G211041035', '黑人牙膏', '3', 14.50, 9.00, 4, 3, '支', '36个月', '2018-04-11 00:00:00', '好来化工（中山）有限公司', '');
INSERT INTO `goods` VALUES (23, 'G211152026', '九阳电热水壶', '7', 26.00, 54.00, 7, 8, '台', '个月', '2018-04-11 00:00:00', '九阳股份有限公司', '');
INSERT INTO `goods` VALUES (24, 'G211318791', '美的WK2102电磁炉', '7', 209.00, 188.00, 5, 3, '台', '个月', '2018-04-11 00:00:00', '美的集团', '');
INSERT INTO `goods` VALUES (25, 'G214612828', '清风抽纸原木金装', '8', 19.90, 55.00, 7, 5, '包', '36个月', '2018-04-11 00:00:00', '金红叶纸业集团有限公司', '');
INSERT INTO `goods` VALUES (27, 'G214856823', '墨西哥牛油果6个', '10', 39.90, 30.00, 19, 10, '只', '5天', '2018-04-11 00:00:00', 'SunMoon', '');
INSERT INTO `goods` VALUES (28, 'G215032340', '四川黄果柑', '10', 5.98, 3.50, 20, 8, '斤', '20天', '2018-04-11 00:00:00', '四川雅安', '');
INSERT INTO `goods` VALUES (29, 'G215310892', '海南小台农芒果', '10', 9.90, 6.00, 17, 10, '只', '10天', '2018-04-11 00:00:00', '海南芒果', '');
INSERT INTO `goods` VALUES (30, 'G215413825', '恒都巴西牛腱子', '10', 29.95, 21.00, 30, 15, '斤', '12个月', '2018-04-11 00:00:00', '恒都巴西', '');
INSERT INTO `goods` VALUES (31, 'G215548456', '恒都巴西牛腩块', '10', 26.95, 18.00, 30, 15, '斤', '12个月', '2018-04-11 00:00:00', '恒都巴西', '');
INSERT INTO `goods` VALUES (32, 'G215609249', '原膳南美白虾仁(中)', '10', 19.90, 16.00, 12, 5, '包', '12个月', '2018-04-11 00:00:00', '越南原膳', '');
INSERT INTO `goods` VALUES (33, 'G215714325', '獐子岛蒜蓉粉丝扇贝', '10', 4.25, 38.00, 22, 12, '斤', '12个月', '2018-04-11 00:00:00', '獐子岛', '');
INSERT INTO `goods` VALUES (34, 'G215931893', '西红柿', '10', 7.90, 4.00, 30, 10, '斤', '5天', '2018-04-11 00:00:00', '山东寿光西红柿', '');
INSERT INTO `goods` VALUES (35, 'G220047925', '山东紫薯', '10', 6.50, 4.00, 15, 5, '斤', '3天', '2018-04-11 00:00:00', '山东紫薯', '');
INSERT INTO `goods` VALUES (36, 'G220145243', '菜园土豆', '10', 3.90, 1.20, 50, 20, '斤', '12个月', '2018-04-11 00:00:00', '山东菜园土豆', '');
INSERT INTO `goods` VALUES (37, 'G220256873', '精选小青菜', '10', 3.80, 2.60, 10, 5, '斤', '3天', '2018-04-11 00:00:00', '青浦精选', '');
INSERT INTO `goods` VALUES (38, '1', '1', '1', 1.00, 1.00, 1, 1, '1', '1', '2018-01-01 11:11:11', '1', '1');
INSERT INTO `goods` VALUES (39, 'G232730672', '小米吹风机', '7', 99.00, 79.00, 100, 10, '台', '36个月', '2021-04-06 23:33:53', '小米集团', '');

-- ----------------------------
-- Table structure for goodscategory
-- ----------------------------
DROP TABLE IF EXISTS `goodscategory`;
CREATE TABLE `goodscategory`  (
  `GCID` int(0) NOT NULL AUTO_INCREMENT COMMENT '商品分类id',
  `GCName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品分类名称',
  PRIMARY KEY (`GCID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 13 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '商品类别表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of goodscategory
-- ----------------------------
INSERT INTO `goodscategory` VALUES (1, '食品饮料');
INSERT INTO `goodscategory` VALUES (2, '粮油副食');
INSERT INTO `goodscategory` VALUES (3, '美容洗护');
INSERT INTO `goodscategory` VALUES (7, '家电');
INSERT INTO `goodscategory` VALUES (8, '家庭清洁');
INSERT INTO `goodscategory` VALUES (10, '生鲜水果');

-- ----------------------------
-- Table structure for goodssupplier
-- ----------------------------
DROP TABLE IF EXISTS `goodssupplier`;
CREATE TABLE `goodssupplier`  (
  `GSID` int(0) NOT NULL AUTO_INCREMENT COMMENT '供应商id',
  `GSName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '供应商名称',
  `GSPName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商联系人姓名',
  `GSTel` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商联系人电话',
  `GSAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商地址',
  `GSNotes` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商备注',
  PRIMARY KEY (`GSID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 27 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '供应商信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of goodssupplier
-- ----------------------------
INSERT INTO `goodssupplier` VALUES (3, '内蒙古蒙牛乳业（集团）股份有限公司', '内先生', '13222222222', '内蒙古', '');
INSERT INTO `goodssupplier` VALUES (4, '内蒙古伊利实业集团股份有限公司', '伊女士', '12342134231', '内蒙古', '');
INSERT INTO `goodssupplier` VALUES (5, '港荣食品发展有限公司', '港女士', '13444444444', '上海', '');
INSERT INTO `goodssupplier` VALUES (6, '百事公司', '百先生', '13555555555', '上海', '');
INSERT INTO `goodssupplier` VALUES (7, '新加坡郭兄弟粮油私人有限公司', '郭先生', '13666666666', '新加坡', '');
INSERT INTO `goodssupplier` VALUES (8, '山东鲁花集团有限公司', '鲁先生', '15111111111', '山东', '');
INSERT INTO `goodssupplier` VALUES (9, '清扬技术中心', '1清女士', '11111111111', '北京', '');
INSERT INTO `goodssupplier` VALUES (10, '好来化工（中山）有限公司', '好先生', '13333333333', '中山', '');
INSERT INTO `goodssupplier` VALUES (11, '九阳股份有限公司', '九先生', '14533333333', '北京', '');
INSERT INTO `goodssupplier` VALUES (12, '美的集团', '美女士', '18888888888', '上海', '');
INSERT INTO `goodssupplier` VALUES (13, '金红叶纸业集团有限公司', '金先生', '18222222222', '上海', '');
INSERT INTO `goodssupplier` VALUES (14, '脱普（中国）企业集团', '朴先生', '12333333333', '中国', '');
INSERT INTO `goodssupplier` VALUES (15, 'SunMoon', 'SunMoon先生', '666666', '墨西哥', '');
INSERT INTO `goodssupplier` VALUES (16, '四川雅安', '雅女士', '11113333333', '四川', '');
INSERT INTO `goodssupplier` VALUES (17, '海南芒果', '芒女士', '2222221111', '海南', '');
INSERT INTO `goodssupplier` VALUES (18, '恒都巴西', '恒女士', '41133333', '巴西', '');
INSERT INTO `goodssupplier` VALUES (19, '越南原膳', '原先生', '4213123123', '越南', '');
INSERT INTO `goodssupplier` VALUES (20, '獐子岛', '獐先生', '5634524', '辽宁大连', '');
INSERT INTO `goodssupplier` VALUES (21, '山东寿光西红柿', '山先生', '123111123', '山东寿光', '');
INSERT INTO `goodssupplier` VALUES (22, '山东紫薯', '董先生', '233534', '山东临沂', '');
INSERT INTO `goodssupplier` VALUES (23, '山东菜园土豆', '蔡先生', '123211245', '山东', '');
INSERT INTO `goodssupplier` VALUES (24, '青浦精选', '清女士', '57214124', '上海青浦', '');
INSERT INTO `goodssupplier` VALUES (27, '小米集团', '雷军', '12545698745', '湖北武汉', 'boss');

-- ----------------------------
-- Table structure for loginlog
-- ----------------------------
DROP TABLE IF EXISTS `loginlog`;
CREATE TABLE `loginlog`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `LoginUserName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登录用户名',
  `LoginTime` datetime(0) NOT NULL COMMENT '登录时间',
  `LoginPublicIP` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登录内网ip',
  `LoginLocalIP` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登录外网ip',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 86 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '登录日志' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of loginlog
-- ----------------------------
INSERT INTO `loginlog` VALUES (1, 'xtgly', '2021-04-23 20:36:53', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (2, 'xtgly', '2021-04-23 23:18:27', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (3, 'xtgly', '2021-04-23 23:24:12', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (4, 'xtgly', '2021-04-23 23:28:37', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (5, 'xtgly', '2021-04-23 23:48:17', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (6, 'xtgly', '2021-04-23 23:52:42', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (7, 'xtgly', '2021-04-24 00:05:10', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (8, 'xtgly', '2021-04-24 00:09:22', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (9, 'xtgly', '2021-04-24 00:21:30', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (10, 'xtgly', '2021-04-24 00:23:54', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (11, 'xtgly', '2021-04-24 12:17:31', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (12, 'xtgly', '2021-04-24 15:36:31', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (13, 'xtgly', '2021-04-24 15:38:37', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (14, 'xtgly', '2021-04-24 15:46:47', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (15, 'syy1', '2021-04-24 21:45:49', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (16, 'syy1', '2021-04-24 21:53:57', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (17, 'syy1', '2021-04-24 22:05:01', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (18, 'syy1', '2021-04-24 22:10:31', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (19, 'xtgly', '2021-04-24 23:45:18', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (20, 'xtgly', '2021-04-24 23:45:57', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (21, 'xtgly', '2021-04-24 23:59:45', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (22, 'xtgly', '2021-04-25 00:16:37', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (23, 'xtgly', '2021-04-25 09:18:55', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (24, 'xtgly', '2021-04-25 09:32:18', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (25, 'xtgly', '2021-04-25 09:36:03', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (26, 'xtgly', '2021-04-25 09:44:21', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (27, 'xtgly', '2021-04-25 09:46:37', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (28, 'xtgly', '2021-04-25 10:26:32', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (29, 'xtgly', '2021-04-25 10:36:22', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (30, 'xtgly', '2021-04-25 11:05:33', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (31, 'xtgly', '2021-04-25 11:29:28', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (32, 'xtgly', '2021-04-25 11:37:43', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (33, 'xtgly', '2021-04-25 11:42:16', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (34, 'xtgly', '2021-04-25 11:44:03', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (35, 'xtgly', '2021-04-25 11:45:14', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (36, 'xtgly', '2021-04-25 12:00:06', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (37, 'xtgly', '2021-04-25 12:01:48', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (38, 'xtgly', '2021-04-25 12:03:17', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (39, 'xtgly', '2021-04-25 12:05:23', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (40, 'xtgly', '2021-04-25 12:16:50', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (41, 'xtgly', '2021-04-25 12:18:08', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (42, 'xtgly', '2021-04-25 12:21:19', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (43, 'xtgly', '2021-04-25 12:27:27', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (44, 'xtgly', '2021-04-25 12:29:45', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (45, 'xtgly', '2021-04-25 12:37:22', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (46, 'xtgly', '2021-04-25 13:05:30', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (47, 'xtgly', '2021-04-25 13:10:21', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (48, 'xtgly', '2021-04-25 15:02:48', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (49, 'xtgly', '2021-04-25 15:03:48', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (50, 'xtgly', '2021-04-25 15:24:07', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (51, 'xtgly', '2021-04-25 15:25:59', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (52, 'xtgly', '2021-04-25 17:00:55', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (53, 'xtgly', '2021-04-25 17:06:46', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (54, 'xtgly', '2021-04-25 17:24:40', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (55, 'xtgly', '2021-04-25 17:28:31', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (56, 'xtgly', '2021-04-25 19:00:45', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (57, 'xtgly', '2021-04-25 19:02:09', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (58, 'xtgly', '2021-04-25 19:19:23', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (59, 'xtgly', '2021-04-25 19:26:44', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (60, 'xtgly', '2021-04-25 20:09:35', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (61, 'xtgly', '2021-04-25 20:09:55', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (62, 'xtgly', '2021-04-25 20:29:19', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (63, 'xtgly', '2021-04-25 20:51:02', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (64, 'xtgly', '2021-04-25 21:27:43', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (65, 'xtgly', '2021-04-25 21:46:28', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (66, 'xtgly', '2021-04-25 21:56:46', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (67, 'xtgly', '2021-04-25 22:04:13', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (68, 'xtgly', '2021-04-25 22:59:36', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (69, 'xtgly', '2021-04-25 23:24:49', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (70, 'syy1', '2021-04-26 16:57:17', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (71, 'syy1', '2021-04-26 16:57:47', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (72, 'xtgly', '2021-04-26 17:22:23', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (73, 'xtgly', '2021-04-26 18:52:40', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (74, 'xtgly', '2021-04-26 18:59:16', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (75, 'xtgly', '2021-04-26 19:03:31', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (76, 'xtgly', '2021-04-26 19:04:33', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (77, 'xtgly', '2021-04-26 19:32:23', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (78, 'xtgly', '2021-04-26 19:34:00', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (79, 'xtgly', '2021-04-26 19:34:38', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (80, 'xtgly', '2021-04-26 22:05:57', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (81, 'xtgly', '2021-04-26 22:07:10', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (82, 'xtgly', '2021-04-26 22:07:47', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (83, 'xtgly', '2021-04-26 22:22:07', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (84, 'xtgly', '2021-04-26 22:32:30', '36.34.90.11', '10.204.0.204');
INSERT INTO `loginlog` VALUES (85, 'xtgly', '2021-04-27 18:00:05', '36.34.90.11', '10.204.0.204');

-- ----------------------------
-- Table structure for purchaseorder
-- ----------------------------
DROP TABLE IF EXISTS `purchaseorder`;
CREATE TABLE `purchaseorder`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `POID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '进货单编号',
  `PODate` date NULL DEFAULT NULL COMMENT '进货日期',
  `POGID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品编号',
  `POGName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品名称',
  `POGCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品类别',
  `POGPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品售价',
  `POGBid` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品进价',
  `POAmount` int(0) NULL DEFAULT NULL COMMENT '进货数量',
  `POGMinimumInventory` int(0) NULL DEFAULT NULL COMMENT '商品最小库存',
  `POGUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品单位',
  `POGShelfLife` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品保质期',
  `POGProductionDate` date NULL DEFAULT NULL COMMENT '商品生产日期',
  `POGSupplier` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商',
  `POGNotes` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 44 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '进货表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of purchaseorder
-- ----------------------------
INSERT INTO `purchaseorder` VALUES (19, 'PO20180411101335', '2018-04-11', 'G20180411085047', '蒙牛纯牛奶', '1', 41.00, 33.00, 20, 10, '箱', '180天', '2018-04-03', '内蒙古蒙牛乳业（集团）股份有限公司', '');
INSERT INTO `purchaseorder` VALUES (20, 'PO20180411101426', '2018-04-11', 'G20180411085233', '伊利安慕希原味酸奶', '1', 49.50, 38.00, 8, 5, '箱', '6个月', '2018-04-11', '内蒙古伊利实业集团股份有限公司', '');
INSERT INTO `purchaseorder` VALUES (21, 'PO20180411101453', '2018-04-11', 'G20180411085421', '港荣奶香蒸蛋糕', '1', 38.20, 26.00, 10, 15, '箱', '35天', '2018-04-11', '港荣食品发展有限公司', '');
INSERT INTO `purchaseorder` VALUES (22, 'PO20180411101525', '2018-04-11', 'G20180411085633', '乐事薯片礼盒', '1', 59.90, 48.00, 30, 20, '箱', '9个月', '2018-04-11', '百事公司', '');
INSERT INTO `purchaseorder` VALUES (23, 'PO20180411101610', '2018-04-11', 'G20180411085832', '百事巴厘岛蓝色可乐', '1', 12.90, 8.00, 45, 30, '瓶', '12个月', '2018-04-11', '百事公司', '');
INSERT INTO `purchaseorder` VALUES (24, 'PO20180411101649', '2018-04-11', 'G20180411085904', '金龙鱼玉米油', '2', 39.90, 31.00, 10, 5, '桶', '18个月', '2018-04-07', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `purchaseorder` VALUES (25, 'PO20180411101752', '2018-04-11', 'G20180411090114', '鲁花5S一级花生油', '2', 119.90, 93.00, 8, 5, '桶', '18个月', '2018-04-11', '山东鲁花集团有限公司', '');
INSERT INTO `purchaseorder` VALUES (26, 'PO20180411101855', '2018-04-11', 'G20180411090854', '金龙鱼盘锦大米', '2', 59.90, 48.00, 20, 10, '袋', '18个月', '2018-04-11', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `purchaseorder` VALUES (27, 'PO20180411102040', '2018-04-11', 'G20180411090927', '清扬男士去屑洗发露', '3', 53.80, 44.00, 6, 5, '瓶', '36个月', '2018-04-11', '清扬技术中心', '');
INSERT INTO `purchaseorder` VALUES (28, 'PO20180411102156', '2018-04-11', 'G20180411091041', '黑人牙膏', '3', 14.50, 9.00, 6, 3, '支', '36个月', '2018-04-11', '好来化工（中山）有限公司', '');
INSERT INTO `purchaseorder` VALUES (29, 'PO20180411102319', '2018-04-11', 'G20180411091152', '九阳电热水壶', '7', 69.00, 54.00, 7, 8, '台', '个月', '2018-04-11', '九阳股份有限公司', '');
INSERT INTO `purchaseorder` VALUES (30, 'PO20180411102359', '2018-04-11', 'G20180411091318', '美的WK2102电磁炉', '7', 209.00, 188.00, 5, 3, '台', '个月', '2018-04-11', '美的集团', '');
INSERT INTO `purchaseorder` VALUES (31, 'PO20180411102440', '2018-04-11', 'G20180411094612', '清风抽纸原木金装', '8', 62.90, 55.00, 7, 5, '包', '36个月', '2018-04-11', '金红叶纸业集团有限公司', '');
INSERT INTO `purchaseorder` VALUES (32, 'PO20180411102521', '2018-04-11', 'G20180411094747', '妙洁点断式垃圾袋', '8', 8.90, 6.00, 10, 7, '只', '48个月', '2018-03-16', '脱普（中国）企业集团', '');
INSERT INTO `purchaseorder` VALUES (33, 'PO20180411102834', '2018-04-11', 'G20180411094856', '墨西哥牛油果6个', '10', 39.90, 30.00, 20, 10, '只', '5天', '2018-04-11', 'SunMoon', '');
INSERT INTO `purchaseorder` VALUES (34, 'PO20180411102949', '2018-04-11', 'G20180411095032', '四川黄果柑', '10', 5.98, 3.50, 20, 8, '斤', '20天', '2018-04-11', '四川雅安', '');
INSERT INTO `purchaseorder` VALUES (35, 'PO20180411103029', '2018-04-11', 'G20180411095310', '海南小台农芒果', '10', 9.90, 6.00, 20, 10, '只', '10天', '2018-04-11', '海南芒果', '');
INSERT INTO `purchaseorder` VALUES (36, 'PO20180411103103', '2018-04-11', 'G20180411095413', '恒都巴西牛腱子', '10', 29.95, 21.00, 30, 15, '斤', '12个月', '2018-04-11', '恒都巴西', '');
INSERT INTO `purchaseorder` VALUES (37, 'PO20180411103140', '2018-04-11', 'G20180411095548', '恒都巴西牛腩块', '10', 26.95, 18.00, 30, 15, '斤', '12个月', '2018-04-11', '恒都巴西', '');
INSERT INTO `purchaseorder` VALUES (38, 'PO20180411103215', '2018-04-11', 'G20180411095609', '原膳南美白虾仁(中)', '10', 19.90, 16.00, 12, 5, '包', '12个月', '2018-04-11', '越南原膳', '');
INSERT INTO `purchaseorder` VALUES (39, 'PO20180411103246', '2018-04-11', 'G20180411095714', '獐子岛蒜蓉粉丝扇贝', '10', 47.25, 38.00, 22, 12, '斤', '12个月', '2018-04-11', '獐子岛', '');
INSERT INTO `purchaseorder` VALUES (40, 'PO20180411103418', '2018-04-11', 'G20180411095931', '西红柿', '10', 7.90, 4.00, 30, 10, '斤', '5天', '2018-04-11', '山东寿光西红柿', '');
INSERT INTO `purchaseorder` VALUES (41, 'PO20180411103453', '2018-04-11', 'G20180411100047', '山东紫薯', '10', 6.50, 4.00, 15, 5, '斤', '3天', '2018-04-11', '山东紫薯', '');
INSERT INTO `purchaseorder` VALUES (42, 'PO20180411103536', '2018-04-11', 'G20180411100145', '菜园土豆', '10', 3.90, 1.20, 50, 20, '斤', '12个月', '2018-04-11', '山东菜园土豆', '');
INSERT INTO `purchaseorder` VALUES (43, 'PO20180411103613', '2018-04-11', 'G20180411100256', '精选小青菜', '10', 3.80, 2.60, 10, 5, '斤', '3天', '2018-04-11', '青浦精选', '');
INSERT INTO `purchaseorder` VALUES (44, 'PO20210425113353', '2021-04-25', 'G232730672', '小米吹风机', '7', 99.00, 79.00, 100, 10, '台', '36个月', '2021-04-06', '小米集团', '');

-- ----------------------------
-- Table structure for returnorder
-- ----------------------------
DROP TABLE IF EXISTS `returnorder`;
CREATE TABLE `returnorder`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `OID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单编号',
  `ROGName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货商品名',
  `ROGCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货商品类别',
  `ROGAomunt` int(0) NULL DEFAULT NULL COMMENT '退货商品数量',
  `ROGPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '退货商品售价',
  `ROGUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货商品单位',
  `ROGSum` decimal(18, 2) NULL DEFAULT NULL COMMENT '退货商品总价',
  `ROPaymentMethod` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单支付方式',
  `ROReason` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货原因',
  `ROID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货id',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '退货信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of returnorder
-- ----------------------------
INSERT INTO `returnorder` VALUES (12, 'MMS20180411104303', '獐子岛蒜蓉粉丝扇贝', '生鲜水果', 1, 47.00, '斤', 47.00, '支付宝', '1', 'RWA20180411104949');
INSERT INTO `returnorder` VALUES (13, 'MMS20180517201551', '九阳电热水壶', '家电', 1, 69.00, '台', 69.00, '支付宝', '1', 'RWA20210424115950');
INSERT INTO `returnorder` VALUES (14, 'MMS20180517201551', '海南小台农芒果', '生鲜水果', 3, 10.00, '只', 30.00, '支付宝', '1', 'RWA20210425091917');
INSERT INTO `returnorder` VALUES (15, 'MMS20180517200415', '九阳电热水壶', '家电', 1, 69.00, '台', 69.00, '支付宝', '1', 'RWA20210425093606');
INSERT INTO `returnorder` VALUES (16, 'MMS20180411104754', '美的WK2102电磁炉', '家电', 1, 209.00, '台', 209.00, '现金', '1', 'RWA20210425112646');

-- ----------------------------
-- Table structure for sellorder
-- ----------------------------
DROP TABLE IF EXISTS `sellorder`;
CREATE TABLE `sellorder`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `OID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '订单编号',
  `OGID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品编号',
  `OGName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品名称',
  `OGCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品分类名称',
  `OGAmount` int(0) NOT NULL COMMENT '商品数量',
  `OGPrice` decimal(18, 2) NOT NULL COMMENT '商品售价',
  `OGUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品单位',
  `OGSum` decimal(18, 2) NOT NULL COMMENT '商品总价',
  `OEID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工id',
  `OPaymentMethod` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单支付方式',
  `IsReturn` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '是否退货',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 39 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '订单信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sellorder
-- ----------------------------
INSERT INTO `sellorder` VALUES (18, 'MMS20180411104303', 'G20180411085233', '伊利安慕希原味酸奶', '食品饮料', 2, 50.00, '箱', 100.00, 'xsy1', '支付宝', '否');
INSERT INTO `sellorder` VALUES (19, 'MMS20180411104303', 'G20180411085832', '百事巴厘岛蓝色可乐', '食品饮料', 1, 13.00, '瓶', 13.00, 'xsy1', '支付宝', '否');
INSERT INTO `sellorder` VALUES (20, 'MMS20180411104303', 'G20180411085633', '乐事薯片礼盒', '食品饮料', 1, 60.00, '箱', 60.00, 'xsy1', '支付宝', '否');
INSERT INTO `sellorder` VALUES (21, 'MMS20180411104303', 'G20180411094856', '墨西哥牛油果6个', '生鲜水果', 1, 40.00, '只', 40.00, 'xsy1', '支付宝', '否');
INSERT INTO `sellorder` VALUES (22, 'MMS20180411104303', 'G20180411095714', '獐子岛蒜蓉粉丝扇贝', '生鲜水果', 1, 47.00, '斤', 47.00, 'xsy1', '支付宝', '是');
INSERT INTO `sellorder` VALUES (23, 'MMS20180411104754', 'G20180411091318', '美的WK2102电磁炉', '家电', 1, 209.00, '台', 209.00, 'xsy1', '现金', '是');
INSERT INTO `sellorder` VALUES (24, 'MMS20180411104754', 'G20180411091041', '黑人牙膏', '美容洗护', 2, 14.00, '支', 28.00, 'xsy1', '现金', '否');
INSERT INTO `sellorder` VALUES (25, 'MMS20180411104754', 'G20180411085904', '金龙鱼玉米油', '粮油副食', 1, 40.00, '桶', 40.00, 'xsy1', '现金', '否');
INSERT INTO `sellorder` VALUES (26, 'MMS20180411104754', 'G20180411094747', '妙洁点断式垃圾袋', '家庭清洁', 2, 9.00, '只', 18.00, 'xsy1', '现金', '否');
INSERT INTO `sellorder` VALUES (27, 'MMS20180411104754', 'G20180411095310', '海南小台农芒果', '生鲜水果', 1, 10.00, '只', 10.00, 'xsy1', '现金', '否');
INSERT INTO `sellorder` VALUES (28, 'MMS20180422153919', 'G205047324', '蒙牛纯牛奶', '食品饮料', 2, 41.00, '箱', 82.00, 'q', '现金', '否');
INSERT INTO `sellorder` VALUES (29, 'MMS20180517200415', 'G211152026', '九阳电热水壶', '家电', 1, 69.00, '台', 69.00, 'syy1', '支付宝', '是');
INSERT INTO `sellorder` VALUES (30, 'MMS20180517200415', 'G215310892', '海南小台农芒果', '生鲜水果', 2, 10.00, '只', 20.00, 'syy1', '支付宝', '否');
INSERT INTO `sellorder` VALUES (31, 'MMS20180517201551', 'G211152026', '九阳电热水壶', '家电', 1, 69.00, '台', 69.00, 'q', '支付宝', '是');
INSERT INTO `sellorder` VALUES (32, 'MMS20180517201551', 'G215310892', '海南小台农芒果', '生鲜水果', 3, 10.00, '只', 30.00, 'q', '支付宝', '是');
INSERT INTO `sellorder` VALUES (33, 'MMS20210425232451', 'G205633524', '乐事薯片礼盒', '食品饮料', 1, 17.00, '箱', 17.00, 'xtgly', '现金', '否');
INSERT INTO `sellorder` VALUES (34, 'MMS20210426165800', 'G210927823', '清扬男士去屑洗发露', '美容洗护', 1, 11.00, '瓶', 11.00, 'syy1', '现金', '否');
INSERT INTO `sellorder` VALUES (35, 'MMS20210426172230', 'G205633524', '乐事薯片礼盒', '食品饮料', 1, 17.00, '箱', 17.00, 'xtgly', '现金', '否');
INSERT INTO `sellorder` VALUES (36, 'MMS20210426185252', 'G210114645', '鲁花5S一级花生油', '粮油副食', 1, 120.00, '桶', 120.00, 'xtgly', '现金', '否');
INSERT INTO `sellorder` VALUES (37, 'MMS20210426185316', 'G205633524', '乐事薯片礼盒', '食品饮料', 9, 17.00, '箱', 153.00, 'xtgly', '现金', '否');
INSERT INTO `sellorder` VALUES (38, 'MMS20210426185917', 'G205421245', '港荣奶香蒸蛋糕', '食品饮料', 1, 38.00, '箱', 38.00, 'xtgly', '现金', '否');
INSERT INTO `sellorder` VALUES (39, 'MMS20210426193440', 'G205633524', '乐事薯片礼盒', '食品饮料', 1, 17.00, '箱', 17.00, 'xtgly', '现金', '否');

-- ----------------------------
-- Table structure for sumorder
-- ----------------------------
DROP TABLE IF EXISTS `sumorder`;
CREATE TABLE `sumorder`  (
  `ID` int(0) NOT NULL AUTO_INCREMENT,
  `SOID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单编号',
  `SumPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '订单总价',
  `SEID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '员工id',
  `SDateTime` datetime(0) NULL DEFAULT NULL COMMENT '销售时间',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sumorder
-- ----------------------------

-- ----------------------------
-- Table structure for vip
-- ----------------------------
DROP TABLE IF EXISTS `vip`;
CREATE TABLE `vip`  (
  `ID` int(0) NOT NULL,
  `Vtel` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `Vname` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `Vsex` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `Vadress` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `Vscore` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of vip
-- ----------------------------

SET FOREIGN_KEY_CHECKS = 1;
